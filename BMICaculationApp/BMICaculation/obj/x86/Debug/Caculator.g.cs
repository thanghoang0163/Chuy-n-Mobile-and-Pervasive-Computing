﻿#pragma checksum "C:\Users\Admin\source\repos\BMICaculationApp\BMICaculation\Caculator.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9901F26FC82E0AA5674332335913C85B34776BEB6EF9E6D5892CEEA0446D031C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BMICaculation
{
    partial class Caculator : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Caculator.xaml line 12
                {
                    this.Introduce = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // Caculator.xaml line 13
                {
                    this.titleHeight = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // Caculator.xaml line 14
                {
                    this.textHeight = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // Caculator.xaml line 15
                {
                    this.titleWeight = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // Caculator.xaml line 16
                {
                    this.textWeight = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // Caculator.xaml line 17
                {
                    this.Gender = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8: // Caculator.xaml line 18
                {
                    this.btnResult = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnResult).Click += this.btnResult_Click;
                }
                break;
            case 9: // Caculator.xaml line 19
                {
                    this.textNote = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10: // Caculator.xaml line 20
                {
                    this.rbtnMale = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                }
                break;
            case 11: // Caculator.xaml line 21
                {
                    this.rbtnFemale = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
