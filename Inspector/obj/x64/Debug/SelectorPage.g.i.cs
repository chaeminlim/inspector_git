﻿#pragma checksum "..\..\..\SelectorPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3CB608099D24108DE27351FD2CB8587A1703B257979E8A00EC038C0549D5CF43"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

using Inspector;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Inspector {
    
    
    /// <summary>
    /// SelectorPage
    /// </summary>
    public partial class SelectorPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\SelectorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listView2;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\SelectorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox1;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\SelectorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonStart;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\SelectorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonStop;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\SelectorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonLoadXml;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\SelectorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FindFromXml;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Inspector;component/selectorpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\SelectorPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\SelectorPage.xaml"
            ((Inspector.SelectorPage)(target)).Initialized += new System.EventHandler(this.Window_Initialized);
            
            #line default
            #line hidden
            return;
            case 2:
            this.listView2 = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.TextBox1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.buttonStart = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\SelectorPage.xaml"
            this.buttonStart.Click += new System.Windows.RoutedEventHandler(this.ButtonStart_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonStop = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\SelectorPage.xaml"
            this.buttonStop.Click += new System.Windows.RoutedEventHandler(this.ButtonStop_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonLoadXml = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\SelectorPage.xaml"
            this.buttonLoadXml.Click += new System.Windows.RoutedEventHandler(this.ButtonLoadXml_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.FindFromXml = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\SelectorPage.xaml"
            this.FindFromXml.Click += new System.Windows.RoutedEventHandler(this.FindFromXml_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

