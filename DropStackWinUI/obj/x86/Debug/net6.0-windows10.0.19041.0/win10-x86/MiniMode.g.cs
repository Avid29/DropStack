﻿#pragma checksum "C:\Users\nicol\OneDrive\Documents\GitHub\DropStack-2\DropStackWinUI\MiniMode.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FEBED7F1B3A6AB1E35269002CBDDB6EE3BAE88CBEC5AFF7C9F00D833D155CA50"
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
    partial class MiniMode : 
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
        private class MiniMode_obj1_Bindings :
            global::Microsoft.UI.Xaml.Markup.IDataTemplateComponent,
            global::Microsoft.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Microsoft.UI.Xaml.Markup.IComponentConnector,
            IMiniMode_Bindings
        {
            private global::DropStackWinUI.MiniMode dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Microsoft.UI.Xaml.Controls.ListView obj16;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj16AttachedFlyoutDisabled = false;
            private static bool isobj16ContextFlyoutDisabled = false;

            public MiniMode_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 58 && columnNumber == 21)
                {
                    isobj16AttachedFlyoutDisabled = true;
                }
                else if (lineNumber == 59 && columnNumber == 21)
                {
                    isobj16ContextFlyoutDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 16: // MiniMode.xaml line 50
                        this.obj16 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ListView>(target);
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

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IMiniMode_Bindings

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
                    this.dataRoot = global::WinRT.CastExtensions.As<global::DropStackWinUI.MiniMode>(newDataRoot);
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
            private void Update_(global::DropStackWinUI.MiniMode obj, int phase)
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
                    // MiniMode.xaml line 50
                    if (!isobj16AttachedFlyoutDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_FlyoutBase_AttachedFlyout(this.obj16, obj, null);
                    }
                    // MiniMode.xaml line 50
                    if (!isobj16ContextFlyoutDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_ContextFlyout(this.obj16, obj, null);
                    }
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
            case 2: // MiniMode.xaml line 18
                {
                    this.FileCommandsFlyout = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.CommandBarFlyout>(target);
                }
                break;
            case 3: // MiniMode.xaml line 19
                {
                    this.FlyoutOpenButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutOpenButton).Click += this.FlyoutOpenButton_Click;
                }
                break;
            case 4: // MiniMode.xaml line 20
                {
                    this.FlyoutCopyButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutCopyButton).Click += this.FlyoutCopyButton_Click;
                }
                break;
            case 5: // MiniMode.xaml line 21
                {
                    this.FlyoutPinUnpinButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutPinUnpinButton).Click += this.PinUnpinButton_Click;
                }
                break;
            case 6: // MiniMode.xaml line 22
                {
                    this.FlyoutPreviewButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutPreviewButton).Click += this.DetailsPanePreviewButton_Click;
                }
                break;
            case 7: // MiniMode.xaml line 24
                {
                    this.FlyoutOpenButtonSec = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutOpenButtonSec).Click += this.FlyoutOpenButton_Click;
                }
                break;
            case 8: // MiniMode.xaml line 25
                {
                    this.FlyoutCopyButtonSec = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutCopyButtonSec).Click += this.FlyoutCopyButton_Click;
                }
                break;
            case 9: // MiniMode.xaml line 26
                {
                    this.FlyoutPinUnpinButtonSec = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutPinUnpinButtonSec).Click += this.PinUnpinButton_Click;
                }
                break;
            case 10: // MiniMode.xaml line 27
                {
                    this.FlyoutPreviewButtonSec = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutPreviewButtonSec).Click += this.DetailsPanePreviewButton_Click;
                }
                break;
            case 11: // MiniMode.xaml line 29
                {
                    this.FlyoutRevealButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutRevealButton).Click += this.FlyoutRevealButton_Click;
                }
                break;
            case 12: // MiniMode.xaml line 34
                {
                    this.TitleBarRectangle = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Shapes.Rectangle>(target);
                }
                break;
            case 13: // MiniMode.xaml line 35
                {
                    this.TitleBarText = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            case 14: // MiniMode.xaml line 41
                {
                    this.ThemeBackgroundParallaxView = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ParallaxView>(target);
                }
                break;
            case 15: // MiniMode.xaml line 45
                {
                    this.ContentBackgroundRectangle = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Shapes.Rectangle>(target);
                }
                break;
            case 16: // MiniMode.xaml line 50
                {
                    this.regularFileListView = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ListView>(target);
                    ((global::Microsoft.UI.Xaml.Controls.ListView)this.regularFileListView).SelectionChanged += this.fileListView_SelectionChanged;
                    ((global::Microsoft.UI.Xaml.Controls.ListView)this.regularFileListView).DoubleTapped += this.fileListView_DoubleTapped;
                    ((global::Microsoft.UI.Xaml.Controls.ListView)this.regularFileListView).RightTapped += this.fileListView_RightTapped;
                    ((global::Microsoft.UI.Xaml.Controls.ListView)this.regularFileListView).DragItemsStarting += this.fileListView_DragItemsStarting;
                    ((global::Microsoft.UI.Xaml.Controls.ListView)this.regularFileListView).Tapped += this.regularFileListView_Tapped;
                }
                break;
            case 17: // MiniMode.xaml line 99
                {
                    this.FileCommandBar = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.CommandBar>(target);
                    ((global::Microsoft.UI.Xaml.Controls.CommandBar)this.FileCommandBar).PointerExited += this.FileCommandBar_PointerExited;
                    ((global::Microsoft.UI.Xaml.Controls.CommandBar)this.FileCommandBar).Closing += this.FileCommandBar_Closing;
                    ((global::Microsoft.UI.Xaml.Controls.CommandBar)this.FileCommandBar).Opening += this.FileCommandBar_Opening;
                }
                break;
            case 18: // MiniMode.xaml line 148
                {
                    this.CommandBarIndicatorPill = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Shapes.Rectangle>(target);
                }
                break;
            case 19: // MiniMode.xaml line 165
                {
                    this.CommandBarIndicatorPillHitbox = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Shapes.Rectangle>(target);
                    ((global::Microsoft.UI.Xaml.Shapes.Rectangle)this.CommandBarIndicatorPillHitbox).PointerEntered += this.CommandBarIndicatorPill_PointerEntered;
                }
                break;
            case 20: // MiniMode.xaml line 116
                {
                    this.CopyRecentFileButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.CopyRecentFileButton).Click += this.CopyRecentFileButton_Click;
                }
                break;
            case 21: // MiniMode.xaml line 121
                {
                    this.RefreshButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.RefreshButton).Click += this.RefreshButton_Click;
                }
                break;
            case 22: // MiniMode.xaml line 128
                {
                    this.RevealInExplorerButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.RevealInExplorerButton).Click += this.RevealInExplorerButton_Click;
                }
                break;
            case 23: // MiniMode.xaml line 134
                {
                    this.HideToolbarButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.HideToolbarButton).Click += this.HideToolbarButton_Click;
                }
                break;
            case 24: // MiniMode.xaml line 139
                {
                    this.MakeSimpleDefaultButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.MakeSimpleDefaultButton).Click += this.MakeSimpleDefaultButton_Click;
                }
                break;
            case 25: // MiniMode.xaml line 141
                {
                    this.CloseSimpleModeButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.CloseSimpleModeButton).Click += this.LoadMoreFromSimpleViewButton_Click;
                }
                break;
            case 30: // MiniMode.xaml line 42
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
            case 1: // MiniMode.xaml line 2
                {                    
                    global::WinUIEx.WindowEx element1 = (global::WinUIEx.WindowEx)target;
                    MiniMode_obj1_Bindings bindings = new MiniMode_obj1_Bindings();
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

