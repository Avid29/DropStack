﻿#pragma checksum "C:\Users\nicol\OneDrive\Documents\GitHub\DropStack\DropStackWinUI\MiniMode.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8D5DCE3EE95EA6BB42CEFDF9A8D2CCAAE7781C4D9CEA1D95C119F34D367DEC8C"
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
            private global::Microsoft.UI.Xaml.Controls.ListView obj12;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj12AttachedFlyoutDisabled = false;
            private static bool isobj12ContextFlyoutDisabled = false;

            public MiniMode_obj1_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 62 && columnNumber == 21)
                {
                    isobj12AttachedFlyoutDisabled = true;
                }
                else if (lineNumber == 63 && columnNumber == 21)
                {
                    isobj12ContextFlyoutDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 12: // MiniMode.xaml line 54
                        this.obj12 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ListView>(target);
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
                    // MiniMode.xaml line 54
                    if (!isobj12AttachedFlyoutDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_Primitives_FlyoutBase_AttachedFlyout(this.obj12, obj, null);
                    }
                    // MiniMode.xaml line 54
                    if (!isobj12ContextFlyoutDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_ContextFlyout(this.obj12, obj, null);
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
            case 2: // MiniMode.xaml line 19
                {
                    this.FileCommandsFlyout = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.CommandBarFlyout>(target);
                }
                break;
            case 3: // MiniMode.xaml line 20
                {
                    this.FlyoutOpenButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutOpenButton).Click += this.FlyoutOpenButton_Click;
                }
                break;
            case 4: // MiniMode.xaml line 21
                {
                    this.FlyoutCopyButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutCopyButton).Click += this.FlyoutCopyButton_Click;
                }
                break;
            case 5: // MiniMode.xaml line 22
                {
                    this.FlyoutPinUnpinButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutPinUnpinButton).Click += this.PinUnpinButton_Click;
                }
                break;
            case 6: // MiniMode.xaml line 23
                {
                    this.FlyoutPreviewButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutPreviewButton).Click += this.DetailsPanePreviewButton_Click;
                }
                break;
            case 7: // MiniMode.xaml line 25
                {
                    this.FlyoutRevealButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.FlyoutRevealButton).Click += this.FlyoutRevealButton_Click;
                }
                break;
            case 8: // MiniMode.xaml line 35
                {
                    this.TitleBarGrid = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 9: // MiniMode.xaml line 44
                {
                    this.ThemeBackgroundParallaxView = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ParallaxView>(target);
                }
                break;
            case 10: // MiniMode.xaml line 48
                {
                    this.EverythingGrid = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 11: // MiniMode.xaml line 49
                {
                    this.ContentBackgroundRectangle = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Shapes.Rectangle>(target);
                }
                break;
            case 12: // MiniMode.xaml line 54
                {
                    this.regularFileListView = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ListView>(target);
                    ((global::Microsoft.UI.Xaml.Controls.ListView)this.regularFileListView).SelectionChanged += this.fileListView_SelectionChanged;
                    ((global::Microsoft.UI.Xaml.Controls.ListView)this.regularFileListView).DoubleTapped += this.fileListView_DoubleTapped;
                    ((global::Microsoft.UI.Xaml.Controls.ListView)this.regularFileListView).RightTapped += this.fileListView_RightTapped;
                    ((global::Microsoft.UI.Xaml.Controls.ListView)this.regularFileListView).DragItemsStarting += this.fileListView_DragItemsStarting;
                    ((global::Microsoft.UI.Xaml.Controls.ListView)this.regularFileListView).Tapped += this.regularFileListView_Tapped;
                }
                break;
            case 13: // MiniMode.xaml line 103
                {
                    this.FileCommandBar = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.CommandBar>(target);
                    ((global::Microsoft.UI.Xaml.Controls.CommandBar)this.FileCommandBar).PointerExited += this.FileCommandBar_PointerExited;
                    ((global::Microsoft.UI.Xaml.Controls.CommandBar)this.FileCommandBar).Closing += this.FileCommandBar_Closing;
                    ((global::Microsoft.UI.Xaml.Controls.CommandBar)this.FileCommandBar).Opening += this.FileCommandBar_Opening;
                }
                break;
            case 14: // MiniMode.xaml line 152
                {
                    this.CommandBarIndicatorPill = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Shapes.Rectangle>(target);
                }
                break;
            case 15: // MiniMode.xaml line 169
                {
                    this.CommandBarIndicatorPillHitbox = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Shapes.Rectangle>(target);
                    ((global::Microsoft.UI.Xaml.Shapes.Rectangle)this.CommandBarIndicatorPillHitbox).PointerEntered += this.CommandBarIndicatorPill_PointerEntered;
                }
                break;
            case 16: // MiniMode.xaml line 120
                {
                    this.CopyRecentFileButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.CopyRecentFileButton).Click += this.CopyRecentFileButton_Click;
                }
                break;
            case 17: // MiniMode.xaml line 125
                {
                    this.RefreshButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.RefreshButton).Click += this.RefreshButton_Click;
                }
                break;
            case 18: // MiniMode.xaml line 132
                {
                    this.RevealInExplorerButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.RevealInExplorerButton).Click += this.RevealInExplorerButton_Click;
                }
                break;
            case 19: // MiniMode.xaml line 138
                {
                    this.HideToolbarButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.HideToolbarButton).Click += this.HideToolbarButton_Click;
                }
                break;
            case 20: // MiniMode.xaml line 143
                {
                    this.MakeSimpleDefaultButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.MakeSimpleDefaultButton).Click += this.MakeSimpleDefaultButton_Click;
                }
                break;
            case 21: // MiniMode.xaml line 145
                {
                    this.CloseSimpleModeButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.CloseSimpleModeButton).Click += this.LoadMoreFromSimpleViewButton_Click;
                }
                break;
            case 26: // MiniMode.xaml line 45
                {
                    this.ParallaxImage = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Image>(target);
                }
                break;
            case 27: // MiniMode.xaml line 36
                {
                    this.TitleBarRectangle = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Shapes.Rectangle>(target);
                }
                break;
            case 28: // MiniMode.xaml line 37
                {
                    this.TitleBarText = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
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

