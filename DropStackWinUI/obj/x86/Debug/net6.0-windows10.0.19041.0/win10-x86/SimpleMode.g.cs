﻿#pragma checksum "C:\Users\nicol\OneDrive\Documents\GitHub\DropStack\DropStackWinUI\SimpleMode.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F056E274F7B46BEE11E59A1F3259F5E17332EB3D05C312A4CC719D78F346466D"
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2404")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Microsoft_UI_Xaml_Controls_Primitives_FlyoutBase_AttachedFlyout(global::Microsoft.UI.Xaml.FrameworkElement obj, global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase), targetNullValue);
                }
                global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase.SetAttachedFlyout(obj, value);
            }
            public static void Set_Microsoft_UI_Xaml_UIElement_ContextFlyout(global::Microsoft.UI.Xaml.UIElement obj, global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase) global::Microsoft.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Microsoft.UI.Xaml.Controls.Primitives.FlyoutBase), targetNullValue);
                }
                obj.ContextFlyout = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2404")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class SimpleMode_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            ISimpleMode_Bindings
        {
            private global::DropStackWinUI.SimpleMode dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.ListView obj15;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj15AttachedFlyoutDisabled = false;
            private static bool isobj15ContextFlyoutDisabled = false;

            public SimpleMode_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 146 && columnNumber == 25)
                {
                    isobj15AttachedFlyoutDisabled = true;
                }
                else if (lineNumber == 147 && columnNumber == 25)
                {
                    isobj15ContextFlyoutDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 15: // SimpleMode.xaml line 137
                        this.obj15 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ListView>(target);
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2404")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
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

            // ISimpleMode_Bindings

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
                    this.dataRoot = global::WinRT.CastExtensions.As<global::DropStackWinUI.SimpleMode>(newDataRoot);
                    return true;
                }
                return false;
            }

            public void Activated(object obj, global::Microsoft.UI.Xaml.WindowActivatedEventArgs data)
            {
                this.Initialize();
            }

            public void Loading(global::Microsoft.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::DropStackWinUI.SimpleMode obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_FileCommandsFlyout(obj.FileCommandsFlyout, phase);
                    }
                }
            }
            private void Update_FileCommandsFlyout(global::Microsoft.UI.Xaml.Controls.CommandBarFlyout obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // SimpleMode.xaml line 137
                    if (!isobj15AttachedFlyoutDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_FlyoutBase_AttachedFlyout(this.obj15, obj, null);
                    }
                    // SimpleMode.xaml line 137
                    if (!isobj15ContextFlyoutDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_ContextFlyout(this.obj15, obj, null);
                    }
                }
            }
        }

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2404")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // SimpleMode.xaml line 18
                {
                    this.ContentGrid = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 3: // SimpleMode.xaml line 20
                {
                    this.FileCommandsFlyout = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.CommandBarFlyout>(target);
                }
                break;
            case 4: // SimpleMode.xaml line 21
                {
                    this.FlyoutOpenButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutOpenButton).Click += this.FlyoutOpenButton_Click;
                }
                break;
            case 5: // SimpleMode.xaml line 22
                {
                    this.FlyoutCopyButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutCopyButton).Click += this.FlyoutCopyButton_Click;
                }
                break;
            case 6: // SimpleMode.xaml line 23
                {
                    this.FlyoutPinUnpinButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutPinUnpinButton).Click += this.PinUnpinButton_Click;
                }
                break;
            case 7: // SimpleMode.xaml line 24
                {
                    this.FlyoutPreviewButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutPreviewButton).Click += this.DetailsPanePreviewButton_Click;
                }
                break;
            case 8: // SimpleMode.xaml line 26
                {
                    this.FlyoutRevealButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutRevealButton).Click += this.FlyoutRevealButton_Click;
                }
                break;
            case 9: // SimpleMode.xaml line 27
                {
                    this.FlyoutSelectButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutSelectButton).Click += this.FlyoutSelectButton_Click;
                }
                break;
            case 10: // SimpleMode.xaml line 32
                {
                    this.ThemeBackgroundParallaxView = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ParallaxView>(target);
                }
                break;
            case 11: // SimpleMode.xaml line 36
                {
                    this.TitleBarRectangle = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Shapes.Rectangle>(target);
                }
                break;
            case 12: // SimpleMode.xaml line 38
                {
                    this.EverythingGrid = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 13: // SimpleMode.xaml line 52
                {
                    this.HeaderGrid = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 14: // SimpleMode.xaml line 83
                {
                    this.ToggleButtonStackPanel = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 15: // SimpleMode.xaml line 137
                {
                    this.regularFileListView = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ListView>(target);
                    ((global::Microsoft.UI.Xaml.Controls.ListView)this.regularFileListView).SelectionChanged += this.fileListView_SelectionChanged;
                    ((global::Microsoft.UI.Xaml.Controls.ListView)this.regularFileListView).DoubleTapped += this.regularFileListView_DoubleTapped;
                    ((global::Microsoft.UI.Xaml.Controls.ListView)this.regularFileListView).RightTapped += this.fileListView_RightTapped;
                    ((global::Microsoft.UI.Xaml.Controls.ListView)this.regularFileListView).DragItemsStarting += this.fileListView_DragItemsStarting;
                    ((global::Microsoft.UI.Xaml.Controls.ListView)this.regularFileListView).DragItemsCompleted += this.regularFileListView_DragItemsCompleted;
                    ((global::Microsoft.UI.Xaml.Controls.ListView)this.regularFileListView).Tapped += this.regularFileListView_Tapped;
                }
                break;
            case 16: // SimpleMode.xaml line 197
                {
                    this.SomethingWentWrongTeachingTip = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TeachingTip>(target);
                    ((global::Microsoft.UI.Xaml.Controls.TeachingTip)this.SomethingWentWrongTeachingTip).ActionButtonClick += this.TeachingTip_ActionButtonClick;
                }
                break;
            case 21: // SimpleMode.xaml line 88
                {
                    this.AltLaunchNormalModeButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.AltLaunchNormalModeButton).Click += this.AltLaunchNormalModeButton_Click;
                }
                break;
            case 22: // SimpleMode.xaml line 92
                {
                    this.FilterButtonsStackPanel = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.StackPanel>(target);
                }
                break;
            case 23: // SimpleMode.xaml line 93
                {
                    this.AllFilesToggleButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.AllFilesToggleButton).Checked += this.ToggleButton_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.AllFilesToggleButton).Unchecked += this.AllFilesToggleButton_Unchecked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.AllFilesToggleButton).RightTapped += this.AllFilesToggleButton_RightTapped;
                }
                break;
            case 24: // SimpleMode.xaml line 98
                {
                    this.PinnedFilesToggleButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.PinnedFilesToggleButton).Checked += this.ToggleButton_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.PinnedFilesToggleButton).Unchecked += this.AllFilesToggleButton_Unchecked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.PinnedFilesToggleButton).RightTapped += this.PinnedFilesToggleButton_RightTapped;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.PinnedFilesToggleButton).DragOver += this.PinnedFilesToggleButton_DragOver;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.PinnedFilesToggleButton).Drop += this.PinnedFilesToggleButton_Drop;
                }
                break;
            case 25: // SimpleMode.xaml line 103
                {
                    global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton element25 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element25).Checked += this.ToggleButton_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element25).Unchecked += this.AllFilesToggleButton_Unchecked;
                }
                break;
            case 26: // SimpleMode.xaml line 108
                {
                    global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton element26 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element26).Checked += this.ToggleButton_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element26).Unchecked += this.AllFilesToggleButton_Unchecked;
                }
                break;
            case 27: // SimpleMode.xaml line 113
                {
                    global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton element27 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element27).Checked += this.ToggleButton_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element27).Unchecked += this.AllFilesToggleButton_Unchecked;
                }
                break;
            case 28: // SimpleMode.xaml line 118
                {
                    global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton element28 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element28).Checked += this.ToggleButton_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element28).Unchecked += this.AllFilesToggleButton_Unchecked;
                }
                break;
            case 29: // SimpleMode.xaml line 123
                {
                    global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton element29 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element29).Checked += this.ToggleButton_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element29).Unchecked += this.AllFilesToggleButton_Unchecked;
                }
                break;
            case 30: // SimpleMode.xaml line 128
                {
                    global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton element30 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element30).Checked += this.ToggleButton_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element30).Unchecked += this.AllFilesToggleButton_Unchecked;
                }
                break;
            case 31: // SimpleMode.xaml line 53
                {
                    this.FlyoutStyleGrid = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 32: // SimpleMode.xaml line 77
                {
                    this.WindowStyleGrid = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 33: // SimpleMode.xaml line 78
                {
                    this.PlaceholderRectangle = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Shapes.Rectangle>(target);
                }
                break;
            case 34: // SimpleMode.xaml line 79
                {
                    this.TitleBarText = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 35: // SimpleMode.xaml line 58
                {
                    this.DragZone = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Shapes.Rectangle>(target);
                }
                break;
            case 36: // SimpleMode.xaml line 59
                {
                    this.FolderDisplay = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 37: // SimpleMode.xaml line 69
                {
                    this.SimpleModeMeatballMenu = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.SimpleModeMeatballMenu).Click += this.SimpleModeMeatballMenu_Click;
                }
                break;
            case 38: // SimpleMode.xaml line 72
                {
                    this.CloseSimpleModeButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.CloseSimpleModeButton).Click += this.CloseSimpleModeButton_Click;
                }
                break;
            case 39: // SimpleMode.xaml line 33
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2404")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // SimpleMode.xaml line 2
                {                    
                    global::WinUIEx.WindowEx element1 = (global::WinUIEx.WindowEx)target;
                    SimpleMode_obj1_Bindings bindings = new SimpleMode_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Activated += bindings.Activated;
                }
                break;
            }
            return returnValue;
        }
    }
}

