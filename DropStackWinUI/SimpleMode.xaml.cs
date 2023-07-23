using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.AccessCache;
using Windows.Storage;
using Microsoft.UI.Xaml.Media.Imaging;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Threading;
using Windows.Storage.FileProperties;
using Windows.System;
using WinUIEx;
using Windows.ApplicationModel.Core;
using System.Formats.Asn1;
using System.ComponentModel.Design;
using Windows.Management.Deployment;

namespace DropStackWinUI
{
    public sealed partial class SimpleMode : WinUIEx.WindowEx
    {
        string folderToken = ApplicationData.Current.LocalSettings.Values["FolderToken"] as string;
        string pinnedFolderToken = ApplicationData.Current.LocalSettings.Values["PinnedFolderToken"] as string;
        IList<string> downloadFileTypes = new List<string> { ".crdownload", ".part" };
        IList<string> documentFileTypes = new List<string> { ".pdf", ".doc", ".docx", ".txt", ".html", ".htm", ".xls", ".xlsx", ".odt", ".fodt", ".ods", ".fods", ".rtf", ".xml" };
        IList<string> pictureFileTypes = new List<string> { ".jpg", ".jpeg", ".png", ".gif", ".bmp", ".tiff", ".svg", ".ico", ".webp", ".raw", ".psd", ".ai" };
        IList<string> musicFileTypes = new List<string> { ".mp3", ".wav", ".flac", ".aac", ".ogg", ".wma", ".m4a", ".mid", ".amr", ".aiff", ".ape" };
        IList<string> videoFileTypes = new List<string> { ".mp4", ".avi", ".mkv", ".mov", ".wmv", ".flv", ".webm", ".3gp", ".m4v", ".mpeg", ".mpg", ".rm", ".vob" };
        IList<string> applicationFileTypes = new List<string> { ".exe", ".dmg", ".app", ".deb", ".apk", ".msi", ".msix", ".rpm", ".jar", ".bat", ".sh", ".com", ".vb", ".gadget", ".ipa" };
        IList<string> presentationFileTypes = new List<string> { ".ppt", ".pptx", ".key", ".odp" };
        IList<object> GlobalClickedItems = null;
        ObservableCollection<FileItem> _filteredFileMetadataList = new ObservableCollection<FileItem>();
        bool isLoading = true;
        bool isSorting = false;
        bool isRefreshRequested = false;
        bool isPinsRefreshRequested = false;
        bool isPinsOnScreen = false;

        public SimpleMode()
        {
            this.InitializeComponent();
            ExtendsContentIntoTitleBar = true;
            obtainFolderAndFiles("portal");
        }

        public async void obtainFolderAndFiles(string source)
        {
            isLoading = true;

            // Get the folder from the access token
            folderToken = ApplicationData.Current.LocalSettings.Values["FolderToken"] as string;
            StorageFolder folder = await StorageApplicationPermissions.FutureAccessList.GetFolderAsync(folderToken);
            FolderDisplay.Text = folder.Name;
            if (source == "pinned")
            {
                folder = await StorageApplicationPermissions.FutureAccessList.GetFolderAsync
                    (ApplicationData.Current.LocalSettings.Values["PinnedFolderToken"] as string);
            }

            // Access the selected folder
            IReadOnlyList<StorageFile> files = await folder.GetFilesAsync();
            ObservableCollection<FileItem> fileMetadataList = new ObservableCollection<FileItem>();

            regularFileListView.ItemsSource = fileMetadataList;

            // Sort the files by modification date in descending order
            files = files.OrderByDescending(f => f.DateCreated).ToList();

            //check for user's way to note the date and time
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            string shortDatePattern = currentCulture.DateTimeFormat.ShortDatePattern;
            string shortTimePattern = currentCulture.DateTimeFormat.ShortTimePattern;

            if (folder != null)
            {
                foreach (StorageFile file in files.Take(256))
                {
                    BasicProperties basicProperties = await file.GetBasicPropertiesAsync();
                    StorageItemThumbnail thumbnail = await file.GetThumbnailAsync(ThumbnailMode.SingleItem, 256);
                    BitmapImage bitmapThumbnail = new BitmapImage();
                    bitmapThumbnail.SetSource(thumbnail);

                    double filesizecalc = Convert.ToDouble(basicProperties.Size); //size in byte
                    string generativefilesizesuffix = "B"; //default file suffix

                    if (filesizecalc >= 1000 && filesizecalc < 1000000)
                    {
                        filesizecalc = Convert.ToDouble(basicProperties.Size) / 1000; //convert to kb
                        filesizecalc = Math.Round(filesizecalc, 0);
                        generativefilesizesuffix = "KB";
                    }

                    else if (filesizecalc >= 1000000 && filesizecalc < 1000000000)
                    {
                        filesizecalc = Convert.ToDouble(basicProperties.Size) / 1000000; //convert to mb
                        filesizecalc = Math.Round(filesizecalc, 1);
                        generativefilesizesuffix = "MB";
                    }

                    else if (filesizecalc >= 1000000000)
                    {
                        filesizecalc = Convert.ToDouble(basicProperties.Size) / 1000000000; //convert to gb
                        filesizecalc = Math.Round(filesizecalc, 2);
                        generativefilesizesuffix = "GB";
                    }

                    else if (filesizecalc >= 1000000000000)
                    {
                        filesizecalc = Convert.ToDouble(basicProperties.Size) / 1000000000000; //convert to gb
                        filesizecalc = Math.Round(filesizecalc, 3);
                        generativefilesizesuffix = "TB";
                    }

                    string modifiedDateFormatted = "n/a";
                    if (DateTime.Now.ToString("d") == basicProperties.DateModified.ToString("d")) modifiedDateFormatted = basicProperties.DateModified.ToString("t");
                    else modifiedDateFormatted = basicProperties.DateModified.ToString("g");

                    string typeTag = "";
                    string typeDisplayName = file.FileType;

                    if (documentFileTypes.Contains(file.FileType.ToLower()))
                    {
                        typeTag = "docs";
                        typeDisplayName = "Document (" + file.FileType + ")";
                    }
                    else if (pictureFileTypes.Contains(file.FileType.ToLower()))
                    {
                        typeTag = "pics";
                        typeDisplayName = "Picture (" + file.FileType + ")";
                    }
                    else if (musicFileTypes.Contains(file.FileType.ToLower()))
                    {
                        typeTag = "music";
                        typeDisplayName = "Music (" + file.FileType + ")";
                    }
                    else if (videoFileTypes.Contains(file.FileType.ToLower()))
                    {
                        typeTag = "vids";
                        typeDisplayName = "Video (" + file.FileType + ")";
                    }
                    else if (applicationFileTypes.Contains(file.FileType.ToLower()))
                    {
                        typeTag = "apps";
                        typeDisplayName = "Application (" + file.FileType + ")";
                    }
                    else if (presentationFileTypes.Contains(file.FileType.ToLower()))
                    {
                        typeTag = "pres";
                        typeDisplayName = "Presentation (" + file.FileType + ")";
                    }

                    if (downloadFileTypes.Contains(file.FileType))
                    {

                        fileMetadataList.Add(new FileItem()
                        {
                            FileName = file.DisplayName,
                            FilePath = file.Path,
                            FileType = "This file is still being downloaded",
                            FileSize = "",
                            FileSizeSuffix = "",
                            ModifiedDate = "",
                            FileIcon = bitmapThumbnail,
                            IconOpacity = 0.25,
                            TextOpacity = 0.5,
                            TextOpacityDate = 0,
                            PillOpacity = 0,
                            ProgressActivity = true
                        });
                    }
                    else
                    {
                        fileMetadataList.Add(new FileItem()
                        {
                            FileName = file.DisplayName,
                            FilePath = file.Path,
                            FileType = typeDisplayName,
                            TypeTag = typeTag,
                            FileSize = filesizecalc.ToString(),
                            FileSizeSuffix = " " + generativefilesizesuffix,
                            ModifiedDate = modifiedDateFormatted,
                            FileIcon = bitmapThumbnail,
                            IconOpacity = 1,
                            TextOpacity = 1,
                            TextOpacityDate = 0.5,
                            PillOpacity = 0.25,
                            ProgressActivity = false
                        });
                    }
                    if(source == "portal")_filteredFileMetadataList = fileMetadataList;
                }
            }
            else
            {
                // Ah bleh
            }
            isLoading = false;
        }

        private void fileListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                GlobalClickedItems = e.AddedItems;
            }
        }

        private async void fileListView_RightTapped(object sender, RightTappedRoutedEventArgs e)
        {
            // get the selected file item
            FileItem selectedFile = (FileItem)((FrameworkElement)e.OriginalSource).DataContext;

            // get the folder path
            StorageFolder folder = await StorageApplicationPermissions.FutureAccessList.GetFolderAsync(folderToken);
            string folderPath = folder.Path;

            // construct the full file path
            string filePath = Path.Combine(folderPath, selectedFile.FileName);

            // get the file
            StorageFile file = await StorageFile.GetFileFromPathAsync(filePath);

            // create a new data package
            var dataPackage = new DataPackage();

            // add the file to the data package
            dataPackage.SetStorageItems(new List<IStorageItem> { file });

            // copy the data package to the clipboard
            Clipboard.SetContent(dataPackage);
        }

        private async void fileListView_DragItemsStarting(object sender, DragItemsStartingEventArgs e)
        {
            try
            {
                var selectedFile = e.Items[0] as FileItem;
                var folder = await StorageApplicationPermissions.FutureAccessList.GetFolderAsync(folderToken);
                var file = await folder.GetFileAsync(selectedFile.FileName);

                // Create a list of storage items with the file
                var storageItems = new List<StorageFile> { file };

                // Set the data package on the event args using SetData
                e.Data.SetData(StandardDataFormats.StorageItems, storageItems);
            }
            catch {}
        }

        private void regularFileListView_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {
            openLastSelectedFile();
        }

        private async void openLastSelectedFile()
        {
            FileItem selectedFile = (FileItem)GlobalClickedItems[0];
            string selectedFileName = selectedFile.FileName;
            StorageFolder folder = await StorageApplicationPermissions.FutureAccessList.GetFolderAsync(folderToken);

            try
            {
                // get the file
                var file = await folder.GetFileAsync(selectedFileName);

                // launch the file
                var success = await Launcher.LaunchFileAsync(file);
            }

            catch
            {
                // handle the exception. ehm.
            }
            finally
            {
                // clear the selection after a short delay
                await Task.Delay(250);
                regularFileListView.SelectedItem = null;
            }
        }

        private void CloseSimpleModeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SimpleModeMeatballMenu_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Activate();

            this.Close();
        }

        private async void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            ToggleButton toggleButton = sender as ToggleButton;
            string sortTag = toggleButton.Tag.ToString();
            if (sortTag == "all" && !isLoading) filterListView("");
            else if (sortTag != "all") filterListView(sortTag);

            if (sortTag == "pins") obtainFolderAndFiles("pinned");

            isSorting = true;
            foreach (ToggleButton listedToggleButton in FilterButtonsStackPanel.Children)
            {
                if (listedToggleButton.Tag.ToString() != toggleButton.Tag.ToString()) listedToggleButton.IsChecked = false;
            }
            isSorting = false;

            isPinsOnScreen = ((ToggleButton)sender == PinnedFilesToggleButton);

            folderToken = ApplicationData.Current.LocalSettings.Values["FolderToken"] as string;
            StorageFolder folder = await StorageApplicationPermissions.FutureAccessList.GetFolderAsync(folderToken);
            if ((ToggleButton)sender == PinnedFilesToggleButton)
            {
                folder = await StorageApplicationPermissions.FutureAccessList.GetFolderAsync(pinnedFolderToken);
            }
            FolderDisplay.Text = folder.Name;
        }

        private void AllFilesToggleButton_Unchecked(object sender, RoutedEventArgs e)
        {
            if (!isSorting)
            {
                if ((ToggleButton)sender == AllFilesToggleButton) isRefreshRequested = true;
                if ((ToggleButton)sender == PinnedFilesToggleButton) isPinsRefreshRequested = true;

                foreach (ToggleButton listedToggleButton in FilterButtonsStackPanel.Children)
                {
                    listedToggleButton.IsChecked = false;
                }
                if (isPinsRefreshRequested) PinnedFilesToggleButton.IsChecked = true;
                else AllFilesToggleButton.IsChecked = true;
            }
        }

        private void filterListView(string filter)
        {
            if (!string.IsNullOrEmpty(filter) && filter != "pins")
            {
                ObservableCollection<FileItem> _filteredItemsCollection = new ObservableCollection<FileItem>
                    (_filteredFileMetadataList.Where(item => item.TypeTag.ToLower().Contains(filter)));
                regularFileListView.ItemsSource = _filteredItemsCollection;
            }
            else if (!string.IsNullOrEmpty(filter) && filter == "pins")
            {
                obtainFolderAndFiles("pinned");
                isPinsRefreshRequested = false;
            }
            else
            {
                if (isRefreshRequested)
                {
                    obtainFolderAndFiles("portal");
                    isRefreshRequested = false;
                }
                else
                {
                    ObservableCollection<FileItem> _filteredItemsCollection = _filteredFileMetadataList;
                    regularFileListView.ItemsSource = _filteredItemsCollection;
                }
            }
        }

        private async void FolderDisplay_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            try
            {
                StorageFolder folder = await StorageApplicationPermissions.FutureAccessList.GetFolderAsync(folderToken);
                if (isPinsOnScreen) folder = await StorageApplicationPermissions.FutureAccessList.GetFolderAsync(pinnedFolderToken);
                await Launcher.LaunchFolderAsync(folder);
            }
            catch { }
        }
    }
}
