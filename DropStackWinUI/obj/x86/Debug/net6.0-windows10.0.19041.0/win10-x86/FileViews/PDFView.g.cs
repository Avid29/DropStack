﻿#pragma checksum "C:\Users\nicol\OneDrive\Documents\GitHub\DropStack\DropStackWinUI\FileViews\PDFView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "36CF6ED9556A3BABE0DD6607275097C7CC8EC3B4A45326B12E9FF3B104D86637"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DropStackWinUI.FileViews
{
    partial class PDFView : 
        global::WinUIEx.WindowEx, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2404")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // FileViews\PDFView.xaml line 17
                {
                    this.TitleBarGrid = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 3: // FileViews\PDFView.xaml line 21
                {
                    this.WebViewRendererComponent = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.WebView2>(target);
                }
                break;
            case 4: // FileViews\PDFView.xaml line 18
                {
                    this.TitleBarRectangle = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Shapes.Rectangle>(target);
                }
                break;
            case 5: // FileViews\PDFView.xaml line 19
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
            return returnValue;
        }
    }
}

