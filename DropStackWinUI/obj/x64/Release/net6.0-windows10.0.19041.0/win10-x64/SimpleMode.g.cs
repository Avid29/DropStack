﻿#pragma checksum "C:\Users\nicol\OneDrive\Documents\GitHub\dropstack\DropStackWinUI\SimpleMode.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "191DABE0D589046829D917683A67F43A50650B0C7E6B434C1FDB5259D0BFBCD2"
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2307")]
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

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2307")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class SimpleMode_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            ISimpleMode_Bindings
        {
            private global::DropStackWinUI.SimpleMode dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.ListView obj13;

            public SimpleMode_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 13: // SimpleMode.xaml line 127
                        this.obj13 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ListView>(target);
                        break;
                    default:
                        break;
                }
            }
                        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2307")]
                        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
                        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target) 
                        {
                            return null;
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
                    // SimpleMode.xaml line 127
                    XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_FlyoutBase_AttachedFlyout(this.obj13, obj, null);
                    // SimpleMode.xaml line 127
                    XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_ContextFlyout(this.obj13, obj, null);
                }
            }
        }

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2307")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // SimpleMode.xaml line 19
                {
                    this.FileCommandsFlyout = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.CommandBarFlyout>(target);
                }
                break;
            case 3: // SimpleMode.xaml line 20
                {
                    this.FlyoutOpenButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutOpenButton).Click += this.FlyoutOpenButton_Click;
                }
                break;
            case 4: // SimpleMode.xaml line 21
                {
                    this.FlyoutCopyButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutCopyButton).Click += this.FlyoutCopyButton_Click;
                }
                break;
            case 5: // SimpleMode.xaml line 22
                {
                    this.FlyoutPinUnpinButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutPinUnpinButton).Click += this.PinUnpinButton_Click;
                }
                break;
            case 6: // SimpleMode.xaml line 24
                {
                    this.FlyoutOpenButtonSec = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutOpenButtonSec).Click += this.FlyoutOpenButton_Click;
                }
                break;
            case 7: // SimpleMode.xaml line 25
                {
                    this.FlyoutCopyButtonSec = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutCopyButtonSec).Click += this.FlyoutCopyButton_Click;
                }
                break;
            case 8: // SimpleMode.xaml line 26
                {
                    this.FlyoutPinUnpinButtonSec = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutPinUnpinButtonSec).Click += this.PinUnpinButton_Click;
                }
                break;
            case 9: // SimpleMode.xaml line 28
                {
                    this.FlyoutRevealButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutRevealButton).Click += this.FlyoutRevealButton_Click;
                }
                break;
            case 10: // SimpleMode.xaml line 29
                {
                    this.FlyoutSelectButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutSelectButton).Click += this.FlyoutSelectButton_Click;
                }
                break;
            case 11: // SimpleMode.xaml line 34
                {
                    this.ThemeBackgroundParallaxView = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ParallaxView>(target);
                }
                break;
            case 12: // SimpleMode.xaml line 38
                {
                    this.EverythingGrid = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 13: // SimpleMode.xaml line 127
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
            case 14: // SimpleMode.xaml line 188
                {
                    this.SomethingWentWrongTeachingTip = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TeachingTip>(target);
                    ((global::Microsoft.UI.Xaml.Controls.TeachingTip)this.SomethingWentWrongTeachingTip).ActionButtonClick += this.TeachingTip_ActionButtonClick;
                }
                break;
            case 19: // SimpleMode.xaml line 83
                {
                    this.FilterButtonsStackPanel = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.StackPanel>(target);
                }
                break;
            case 20: // SimpleMode.xaml line 84
                {
                    this.AllFilesToggleButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.AllFilesToggleButton).Checked += this.ToggleButton_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.AllFilesToggleButton).Unchecked += this.AllFilesToggleButton_Unchecked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.AllFilesToggleButton).RightTapped += this.AllFilesToggleButton_RightTapped;
                }
                break;
            case 21: // SimpleMode.xaml line 89
                {
                    this.PinnedFilesToggleButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.PinnedFilesToggleButton).Checked += this.ToggleButton_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.PinnedFilesToggleButton).Unchecked += this.AllFilesToggleButton_Unchecked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.PinnedFilesToggleButton).RightTapped += this.PinnedFilesToggleButton_RightTapped;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.PinnedFilesToggleButton).DragOver += this.PinnedFilesToggleButton_DragOver;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)this.PinnedFilesToggleButton).Drop += this.PinnedFilesToggleButton_Drop;
                }
                break;
            case 22: // SimpleMode.xaml line 94
                {
                    global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton element22 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element22).Checked += this.ToggleButton_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element22).Unchecked += this.AllFilesToggleButton_Unchecked;
                }
                break;
            case 23: // SimpleMode.xaml line 99
                {
                    global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton element23 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element23).Checked += this.ToggleButton_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element23).Unchecked += this.AllFilesToggleButton_Unchecked;
                }
                break;
            case 24: // SimpleMode.xaml line 104
                {
                    global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton element24 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element24).Checked += this.ToggleButton_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element24).Unchecked += this.AllFilesToggleButton_Unchecked;
                }
                break;
            case 25: // SimpleMode.xaml line 109
                {
                    global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton element25 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element25).Checked += this.ToggleButton_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element25).Unchecked += this.AllFilesToggleButton_Unchecked;
                }
                break;
            case 26: // SimpleMode.xaml line 114
                {
                    global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton element26 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element26).Checked += this.ToggleButton_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element26).Unchecked += this.AllFilesToggleButton_Unchecked;
                }
                break;
            case 27: // SimpleMode.xaml line 119
                {
                    global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton element27 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element27).Checked += this.ToggleButton_Checked;
                    ((global::Microsoft.UI.Xaml.Controls.Primitives.ToggleButton)element27).Unchecked += this.AllFilesToggleButton_Unchecked;
                }
                break;
            case 28: // SimpleMode.xaml line 57
                {
                    this.DragZone = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Shapes.Rectangle>(target);
                }
                break;
            case 29: // SimpleMode.xaml line 58
                {
                    this.FolderDisplay = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 30: // SimpleMode.xaml line 67
                {
                    this.SimpleModeMeatballMenu = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.SimpleModeMeatballMenu).Click += this.SimpleModeMeatballMenu_Click;
                }
                break;
            case 31: // SimpleMode.xaml line 73
                {
                    this.CloseSimpleModeButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.CloseSimpleModeButton).Click += this.CloseSimpleModeButton_Click;
                }
                break;
            case 32: // SimpleMode.xaml line 35
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

