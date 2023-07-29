﻿#pragma checksum "C:\Users\nicol\OneDrive\Documents\GitHub\dropstack\DropStackWinUI\SimpleMode.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4B29D584E5B53AE48A30E992824F27F98B373449A0E157AFF42C9E49C552230E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DropStackWinUI
{
    partial class SimpleMode : 
        global::WinUIEx.WindowEx, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2307")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // SimpleMode.xaml line 18
                {
                    this.ThemeBackgroundParallaxView = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ParallaxView>(target);
                }
                break;
            case 3: // SimpleMode.xaml line 22
                {
                    this.EverythingGrid = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 4: // SimpleMode.xaml line 111
                {
                    this.regularFileListView = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ListView>(target);
                    ((global::Microsoft.UI.Xaml.Controls.ListView)this.regularFileListView).SelectionChanged += this.fileListView_SelectionChanged;
                    ((global::Microsoft.UI.Xaml.Controls.ListView)this.regularFileListView).DoubleTapped += this.regularFileListView_DoubleTapped;
                    ((global::Microsoft.UI.Xaml.Controls.ListView)this.regularFileListView).RightTapped += this.fileListView_RightTapped;
                    ((global::Microsoft.UI.Xaml.Controls.ListView)this.regularFileListView).DragItemsStarting += this.fileListView_DragItemsStarting;
                    ((global::Microsoft.UI.Xaml.Controls.ListView)this.regularFileListView).DragItemsCompleted += this.regularFileListView_DragItemsCompleted;
                }
                break;
            case 5: // SimpleMode.xaml line 168
                {
                    this.SomethingWentWrongTeachingTip = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TeachingTip>(target);
                    ((global::Microsoft.UI.Xaml.Controls.TeachingTip)this.SomethingWentWrongTeachingTip).ActionButtonClick += this.TeachingTip_ActionButtonClick;
                }
                break;
            case 10: // SimpleMode.xaml line 67
                {
                    this.FilterButtonsStackPanel = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.StackPanel>(target);
                }
                break;
            case 11: // SimpleMode.xaml line 68
                {
                    this.AllFilesToggleButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.AllFilesToggleButton).Checked += this.ToggleButton_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.AllFilesToggleButton).Unchecked += this.AllFilesToggleButton_Unchecked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.AllFilesToggleButton).RightTapped += this.AllFilesToggleButton_RightTapped;
                }
                break;
            case 12: // SimpleMode.xaml line 73
                {
                    this.PinnedFilesToggleButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.PinnedFilesToggleButton).Checked += this.ToggleButton_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.PinnedFilesToggleButton).Unchecked += this.AllFilesToggleButton_Unchecked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.PinnedFilesToggleButton).RightTapped += this.PinnedFilesToggleButton_RightTapped;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.PinnedFilesToggleButton).DragOver += this.PinnedFilesToggleButton_DragOver;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.PinnedFilesToggleButton).Drop += this.PinnedFilesToggleButton_Drop;
                }
                break;
            case 13: // SimpleMode.xaml line 78
                {
                    global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton element13 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element13).Checked += this.ToggleButton_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element13).Unchecked += this.AllFilesToggleButton_Unchecked;
                }
                break;
            case 14: // SimpleMode.xaml line 83
                {
                    global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton element14 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element14).Checked += this.ToggleButton_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element14).Unchecked += this.AllFilesToggleButton_Unchecked;
                }
                break;
            case 15: // SimpleMode.xaml line 88
                {
                    global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton element15 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element15).Checked += this.ToggleButton_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element15).Unchecked += this.AllFilesToggleButton_Unchecked;
                }
                break;
            case 16: // SimpleMode.xaml line 93
                {
                    global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton element16 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element16).Checked += this.ToggleButton_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element16).Unchecked += this.AllFilesToggleButton_Unchecked;
                }
                break;
            case 17: // SimpleMode.xaml line 98
                {
                    global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton element17 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element17).Checked += this.ToggleButton_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element17).Unchecked += this.AllFilesToggleButton_Unchecked;
                }
                break;
            case 18: // SimpleMode.xaml line 103
                {
                    global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton element18 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element18).Checked += this.ToggleButton_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element18).Unchecked += this.AllFilesToggleButton_Unchecked;
                }
                break;
            case 19: // SimpleMode.xaml line 41
                {
                    this.DragZone = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Shapes.Rectangle>(target);
                }
                break;
            case 20: // SimpleMode.xaml line 42
                {
                    this.FolderDisplay = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 21: // SimpleMode.xaml line 51
                {
                    this.SimpleModeMeatballMenu = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.SimpleModeMeatballMenu).Click += this.SimpleModeMeatballMenu_Click;
                }
                break;
            case 22: // SimpleMode.xaml line 57
                {
                    this.CloseSimpleModeButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.CloseSimpleModeButton).Click += this.CloseSimpleModeButton_Click;
                }
                break;
            case 23: // SimpleMode.xaml line 19
                {
                    this.ParallaxImage = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Image>(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2307")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

