﻿#pragma checksum "C:\Users\nicol\OneDrive\Documents\GitHub\dropstack\DropStack\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FB1F1D32393150F55AA3555D978D769DCE300ABEFFBCFE825CD38E8294BC8CE5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DropStack
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_TeachingTip_Target(global::Microsoft.UI.Xaml.Controls.TeachingTip obj, global::Windows.UI.Xaml.FrameworkElement value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.FrameworkElement) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.FrameworkElement), targetNullValue);
                }
                obj.Target = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::DropStack.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.TeachingTip obj11;
            private global::Microsoft.UI.Xaml.Controls.TeachingTip obj12;
            private global::Windows.UI.Xaml.Controls.TextBlock obj17;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj11TargetDisabled = false;
            private static bool isobj12TargetDisabled = false;
            private static bool isobj17TextDisabled = false;

            public MainPage_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 324 && columnNumber == 10)
                {
                    isobj11TargetDisabled = true;
                }
                else if (lineNumber == 333 && columnNumber == 10)
                {
                    isobj12TargetDisabled = true;
                }
                else if (lineNumber == 459 && columnNumber == 48)
                {
                    isobj17TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 11: // MainPage.xaml line 320
                        this.obj11 = (global::Microsoft.UI.Xaml.Controls.TeachingTip)target;
                        break;
                    case 12: // MainPage.xaml line 329
                        this.obj12 = (global::Microsoft.UI.Xaml.Controls.TeachingTip)target;
                        break;
                    case 17: // MainPage.xaml line 459
                        this.obj17 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::DropStack.MainPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            private delegate void InvokeFunctionDelegate(int phase);
            private global::System.Collections.Generic.Dictionary<string, InvokeFunctionDelegate> PendingFunctionBindings = new global::System.Collections.Generic.Dictionary<string, InvokeFunctionDelegate>();

            private void Invoke_M_GetAppVersion_371857150(int phase)
            {
                global::System.String result = this.dataRoot.GetAppVersion();
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 459
                    if (!isobj17TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj17, result, null);
                    }
                }
            }

            private void CompleteUpdate(int phase)
            {
                var functions = this.PendingFunctionBindings;
                this.PendingFunctionBindings = new global::System.Collections.Generic.Dictionary<string, InvokeFunctionDelegate>();
                foreach (var function in functions.Values)
                {
                    function.Invoke(phase);
                }
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::DropStack.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_RevealInExplorerButton(obj.RevealInExplorerButton, phase);
                        this.Update_M_GetAppVersion_371857150(phase);
                    }
                }
                this.CompleteUpdate(phase);
            }
            private void Update_RevealInExplorerButton(global::Windows.UI.Xaml.Controls.AppBarButton obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 320
                    if (!isobj11TargetDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TeachingTip_Target(this.obj11, obj, null);
                    }
                    // MainPage.xaml line 329
                    if (!isobj12TargetDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TeachingTip_Target(this.obj12, obj, null);
                    }
                }
            }
            private void Update_M_GetAppVersion_371857150(int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    if (!isobj17TextDisabled)
                    {
                        this.PendingFunctionBindings["M_GetAppVersion_371857150"] = new InvokeFunctionDelegate(this.Invoke_M_GetAppVersion_371857150); 
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 17
                {
                    this.ContentGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // MainPage.xaml line 18
                {
                    this.RegularAndPinnedFileGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4: // MainPage.xaml line 154
                {
                    this.FileCommandBar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 5: // MainPage.xaml line 205
                {
                    this.SearchGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 6: // MainPage.xaml line 215
                {
                    this.fileInClipboardReminder = (global::Microsoft.UI.Xaml.Controls.TeachingTip)(target);
                }
                break;
            case 7: // MainPage.xaml line 220
                {
                    this.failedToDragTeachingTip = (global::Microsoft.UI.Xaml.Controls.TeachingTip)(target);
                }
                break;
            case 8: // MainPage.xaml line 225
                {
                    this.noFolderpathTechingTip = (global::Microsoft.UI.Xaml.Controls.TeachingTip)(target);
                    ((global::Microsoft.UI.Xaml.Controls.TeachingTip)this.noFolderpathTechingTip).ActionButtonClick += this.noFolderpathTechingTip_ActionButtonClick;
                }
                break;
            case 9: // MainPage.xaml line 234
                {
                    this.noPinnedFolderpathTechingTip = (global::Microsoft.UI.Xaml.Controls.TeachingTip)(target);
                    ((global::Microsoft.UI.Xaml.Controls.TeachingTip)this.noPinnedFolderpathTechingTip).ActionButtonClick += this.noPinnedFolderpathTechingTip_ActionButtonClick;
                }
                break;
            case 10: // MainPage.xaml line 243
                {
                    this.quickSettingsFlyoutTeachingTip = (global::Microsoft.UI.Xaml.Controls.TeachingTip)(target);
                    ((global::Microsoft.UI.Xaml.Controls.TeachingTip)this.quickSettingsFlyoutTeachingTip).Closed += this.quickSettingsFlyoutTeachingTip_Closed;
                }
                break;
            case 11: // MainPage.xaml line 320
                {
                    this.cannotOpenRegularFolderBecauseThereIsNoneTeachingTip = (global::Microsoft.UI.Xaml.Controls.TeachingTip)(target);
                    ((global::Microsoft.UI.Xaml.Controls.TeachingTip)this.cannotOpenRegularFolderBecauseThereIsNoneTeachingTip).ActionButtonClick += this.cannotOpenRegularFolderBecauseThereIsNoneTeachingTip_ActionButtonClick;
                }
                break;
            case 12: // MainPage.xaml line 329
                {
                    this.cannotOpenPinnedFolderBecauseThereIsNoneTeachingTip = (global::Microsoft.UI.Xaml.Controls.TeachingTip)(target);
                    ((global::Microsoft.UI.Xaml.Controls.TeachingTip)this.cannotOpenPinnedFolderBecauseThereIsNoneTeachingTip).ActionButtonClick += this.cannotOpenPinnedFolderBecauseThereIsNoneTeachingTip_ActionButtonClick;
                }
                break;
            case 13: // MainPage.xaml line 339
                {
                    this.OOBEgrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 14: // MainPage.xaml line 406
                {
                    this.AboutDropStackGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 15: // MainPage.xaml line 412
                {
                    this.AboutDropStackContentGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 16: // MainPage.xaml line 421
                {
                    this.AboutDropStackCloseButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.AboutDropStackCloseButton).Click += this.AboutDropStackCloseButton_Click;
                }
                break;
            case 18: // MainPage.xaml line 346
                {
                    this.OOBEbackgroundRectangle = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 19: // MainPage.xaml line 348
                {
                    this.OOBEpivot = (global::Windows.UI.Xaml.Controls.Pivot)(target);
                    ((global::Windows.UI.Xaml.Controls.Pivot)this.OOBEpivot).SelectionChanged += this.OOBEpivot_SelectionChanged;
                }
                break;
            case 20: // MainPage.xaml line 401
                {
                    this.OOBEgoBackButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.OOBEgoBackButton).Click += this.OOBEgoBackButton_Click;
                }
                break;
            case 21: // MainPage.xaml line 402
                {
                    this.OOBEgoNextButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.OOBEgoNextButton).Click += this.OOBEgoNextButton_Click;
                }
                break;
            case 22: // MainPage.xaml line 363
                {
                    this.OOBEsetupPivot = (global::Windows.UI.Xaml.Controls.Pivot)(target);
                }
                break;
            case 23: // MainPage.xaml line 384
                {
                    this.OOBEpinnedFileAccessRequestButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.OOBEpinnedFileAccessRequestButton).Click += this.OOBEpinnedFileAccessRequestButton_Click;
                }
                break;
            case 24: // MainPage.xaml line 372
                {
                    this.OOBEportalFileAccessRequestButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.OOBEportalFileAccessRequestButton).Click += this.OOBEportalFileAccessRequestButton_Click;
                }
                break;
            case 25: // MainPage.xaml line 248
                {
                    this.UseSimpleViewByDefaultToggle = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.UseSimpleViewByDefaultToggle).Toggled += this.UseSimpleViewByDefaultToggle_Toggled;
                }
                break;
            case 26: // MainPage.xaml line 254
                {
                    this.SimpleViewRelauncherButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.SimpleViewRelauncherButton).Click += this.SimpleViewRelauncherButton_Click;
                }
                break;
            case 27: // MainPage.xaml line 261
                {
                    this.PinToolbarInSimpleModeToggleSwitch = (global::Windows.UI.Xaml.Controls.ToggleSwitch)(target);
                    ((global::Windows.UI.Xaml.Controls.ToggleSwitch)this.PinToolbarInSimpleModeToggleSwitch).Toggled += this.PinToolbarInSimpleModeToggleSwitch_Toggled;
                }
                break;
            case 28: // MainPage.xaml line 266
                {
                    this.ExpanderSettingsExpander = (global::Microsoft.UI.Xaml.Controls.Expander)(target);
                }
                break;
            case 29: // MainPage.xaml line 277
                {
                    this.deleteFolderCookieButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 30: // MainPage.xaml line 284
                {
                    global::Windows.UI.Xaml.Controls.Flyout element30 = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                    ((global::Windows.UI.Xaml.Controls.Flyout)element30).Opened += this.Flyout_Opened;
                }
                break;
            case 31: // MainPage.xaml line 310
                {
                    global::Windows.UI.Xaml.Controls.Button element31 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element31).Click += this.disconnectFolderButton_Click;
                }
                break;
            case 32: // MainPage.xaml line 305
                {
                    this.PinnedFolderPathDisplay = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 33: // MainPage.xaml line 306
                {
                    this.CopyPinnedFolderPathButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.CopyPinnedFolderPathButton).Click += this.CopyPinnedFolderPathButton_Click;
                }
                break;
            case 34: // MainPage.xaml line 295
                {
                    this.RegularFolderPathDisplay = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 35: // MainPage.xaml line 296
                {
                    this.CopyRegularFolderPathButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.CopyRegularFolderPathButton).Click += this.CopyRegularFolderPathButton_Click;
                }
                break;
            case 36: // MainPage.xaml line 274
                {
                    this.EnableAllOptionsForPinsButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.EnableAllOptionsForPinsButton).Click += this.EnableAllOptionsForPinsButton_Click;
                }
                break;
            case 37: // MainPage.xaml line 269
                {
                    this.PinsAlwaysOpenRadioButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.PinsAlwaysOpenRadioButton).Checked += this.RadioButton_Checked;
                }
                break;
            case 38: // MainPage.xaml line 270
                {
                    this.PinsRememberStateRadioButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.PinsRememberStateRadioButton).Checked += this.RadioButton_Checked;
                }
                break;
            case 39: // MainPage.xaml line 271
                {
                    this.PinsAlwaysClosedRadioButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.PinsAlwaysClosedRadioButton).Checked += this.RadioButton_Checked;
                }
                break;
            case 40: // MainPage.xaml line 272
                {
                    this.PinsProtectedRadioButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.PinsProtectedRadioButton).Checked += this.RadioButton_Checked;
                }
                break;
            case 41: // MainPage.xaml line 223
                {
                    this.failureReminderTimer = (global::Microsoft.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 42: // MainPage.xaml line 218
                {
                    this.reminderTimer = (global::Microsoft.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 43: // MainPage.xaml line 213
                {
                    this.SearchTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.SearchTextBox).TextChanged += this.SearchTextBox_TextChanged;
                }
                break;
            case 44: // MainPage.xaml line 155
                {
                    this.SearchButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.SearchButton).Click += this.SearchButton_Click;
                }
                break;
            case 45: // MainPage.xaml line 161
                {
                    this.CopyLastSelectedButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.CopyLastSelectedButton).Click += this.CopyLastSelectedButton_Click;
                }
                break;
            case 46: // MainPage.xaml line 167
                {
                    this.RefreshButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.RefreshButton).Click += this.RefreshButton_Click;
                }
                break;
            case 47: // MainPage.xaml line 173
                {
                    this.RevealInExplorerButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.RevealInExplorerButton).Click += this.RevealInExplorerButton_Click;
                }
                break;
            case 48: // MainPage.xaml line 179
                {
                    this.LaunchSimpleModeButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.LaunchSimpleModeButton).Click += this.LaunchSimpleModeButton_Click;
                }
                break;
            case 49: // MainPage.xaml line 185
                {
                    this.CopyRecentFileButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.CopyRecentFileButton).Click += this.CopyRecentFileButton_Click;
                }
                break;
            case 50: // MainPage.xaml line 190
                {
                    this.OpenFileButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.OpenFileButton).Click += this.OpenFileButton_Click;
                }
                break;
            case 51: // MainPage.xaml line 197
                {
                    this.QuickSettingsButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.QuickSettingsButton).Click += this.QuickSettingsButton_Click;
                }
                break;
            case 52: // MainPage.xaml line 202
                {
                    this.AboutDropStackButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.AboutDropStackButton).Click += this.AboutDropStackButton_Click;
                }
                break;
            case 53: // MainPage.xaml line 26
                {
                    this.PinnedFilesExpander = (global::Microsoft.UI.Xaml.Controls.Expander)(target);
                    ((global::Microsoft.UI.Xaml.Controls.Expander)this.PinnedFilesExpander).DragOver += this.PinnedPivotSection_DragOver;
                    ((global::Microsoft.UI.Xaml.Controls.Expander)this.PinnedFilesExpander).Drop += this.PinnedPivotSection_Drop;
                    ((global::Microsoft.UI.Xaml.Controls.Expander)this.PinnedFilesExpander).Expanding += this.Expander_Expanding;
                    ((global::Microsoft.UI.Xaml.Controls.Expander)this.PinnedFilesExpander).Collapsed += this.PinnedFilesExpander_Collapsed;
                }
                break;
            case 54: // MainPage.xaml line 91
                {
                    this.regularFileGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 55: // MainPage.xaml line 95
                {
                    this.ContentBackgroundRectangle = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 56: // MainPage.xaml line 96
                {
                    this.PortalFileLoadingProgressBar = (global::Microsoft.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 57: // MainPage.xaml line 103
                {
                    this.regularFileListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.regularFileListView).SelectionChanged += this.fileListView_SelectionChanged;
                    ((global::Windows.UI.Xaml.Controls.ListView)this.regularFileListView).DoubleTapped += this.regularFileListView_DoubleTapped;
                    ((global::Windows.UI.Xaml.Controls.ListView)this.regularFileListView).RightTapped += this.fileListView_RightTapped;
                    ((global::Windows.UI.Xaml.Controls.ListView)this.regularFileListView).DragItemsStarting += this.fileListView_DragItemsStarting;
                }
                break;
            case 58: // MainPage.xaml line 149
                {
                    this.regularFilePusher = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 63: // MainPage.xaml line 41
                {
                    this.WinHelloWaitingIndicator = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 64: // MainPage.xaml line 45
                {
                    this.NoPinnedFilesTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 65: // MainPage.xaml line 46
                {
                    this.NoPinnedFolderStackpanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 66: // MainPage.xaml line 50
                {
                    this.pinnedFileGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 67: // MainPage.xaml line 52
                {
                    this.pinnedFileListView = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    ((global::Windows.UI.Xaml.Controls.GridView)this.pinnedFileListView).SelectionChanged += this.pinnedFileListView_SelectionChanged;
                    ((global::Windows.UI.Xaml.Controls.GridView)this.pinnedFileListView).DoubleTapped += this.pinnedFileListView_DoubleTapped;
                    ((global::Windows.UI.Xaml.Controls.GridView)this.pinnedFileListView).RightTapped += this.pinnedFileListView_RightTapped;
                    ((global::Windows.UI.Xaml.Controls.GridView)this.pinnedFileListView).DragItemsStarting += this.pinnedFileListView_DragItemsStarting;
                }
                break;
            case 72: // MainPage.xaml line 47
                {
                    this.NoPinnedFolderTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 73: // MainPage.xaml line 48
                {
                    this.PickPinnedFolderHyperlinkButton = (global::Windows.UI.Xaml.Controls.HyperlinkButton)(target);
                    ((global::Windows.UI.Xaml.Controls.HyperlinkButton)this.PickPinnedFolderHyperlinkButton).Click += this.PickPinnedFolderHyperlinkButton_Click;
                }
                break;
            case 74: // MainPage.xaml line 42
                {
                    this.WinHelloProgressRing = (global::Microsoft.UI.Xaml.Controls.ProgressRing)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // MainPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

