﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "21D5B045EC41F5F83F5D98E040336B41D41DE502978D205FBB99B4DFC19C15B5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WpfTest3;


namespace WpfTest3 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WpfTest3.MainWindow mainWindow;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid mainGrid;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu mainMenu;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbYellow;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbRed;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbBlue;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbGreen;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock StatusText;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfTest3;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.mainWindow = ((WpfTest3.MainWindow)(target));
            return;
            case 2:
            this.mainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.mainMenu = ((System.Windows.Controls.Menu)(target));
            return;
            case 4:
            this.rbYellow = ((System.Windows.Controls.RadioButton)(target));
            
            #line 12 "..\..\MainWindow.xaml"
            this.rbYellow.Click += new System.Windows.RoutedEventHandler(this.Color_Click);
            
            #line default
            #line hidden
            
            #line 12 "..\..\MainWindow.xaml"
            this.rbYellow.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Btn_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 5:
            this.rbRed = ((System.Windows.Controls.RadioButton)(target));
            
            #line 13 "..\..\MainWindow.xaml"
            this.rbRed.Click += new System.Windows.RoutedEventHandler(this.Color_Click);
            
            #line default
            #line hidden
            
            #line 13 "..\..\MainWindow.xaml"
            this.rbRed.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Btn_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 6:
            this.rbBlue = ((System.Windows.Controls.RadioButton)(target));
            
            #line 14 "..\..\MainWindow.xaml"
            this.rbBlue.Click += new System.Windows.RoutedEventHandler(this.Color_Click);
            
            #line default
            #line hidden
            
            #line 14 "..\..\MainWindow.xaml"
            this.rbBlue.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Btn_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 7:
            this.rbGreen = ((System.Windows.Controls.RadioButton)(target));
            
            #line 15 "..\..\MainWindow.xaml"
            this.rbGreen.Click += new System.Windows.RoutedEventHandler(this.Color_Click);
            
            #line default
            #line hidden
            
            #line 15 "..\..\MainWindow.xaml"
            this.rbGreen.MouseEnter += new System.Windows.Input.MouseEventHandler(this.Btn_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 16 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Close_Click);
            
            #line default
            #line hidden
            
            #line 16 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.MenuItem_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 18 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.About_Click);
            
            #line default
            #line hidden
            
            #line 18 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.MenuItem_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 22 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Color_Click);
            
            #line default
            #line hidden
            
            #line 22 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Btn_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 24 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Color_Click);
            
            #line default
            #line hidden
            
            #line 24 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Btn_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 26 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Color_Click);
            
            #line default
            #line hidden
            
            #line 26 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Btn_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 28 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Color_Click);
            
            #line default
            #line hidden
            
            #line 28 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Btn_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 30 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.About_Click);
            
            #line default
            #line hidden
            
            #line 30 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Btn_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 32 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Close_Click);
            
            #line default
            #line hidden
            
            #line 32 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.Btn_MouseEnter);
            
            #line default
            #line hidden
            return;
            case 16:
            this.StatusText = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

