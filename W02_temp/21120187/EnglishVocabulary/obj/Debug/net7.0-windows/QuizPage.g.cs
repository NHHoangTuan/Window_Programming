﻿#pragma checksum "..\..\..\QuizPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D58BABBC2EE428A70B049D0123681363048C199F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using EnglishVocabulary;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace EnglishVocabulary {
    
    
    /// <summary>
    /// QuizPage
    /// </summary>
    public partial class QuizPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\QuizPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas myCanvas;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\QuizPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNext;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\QuizPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnResult;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\QuizPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image2;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\QuizPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image1;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\QuizPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock testWord;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\QuizPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton cbImg1;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\QuizPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton cbImg2;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/EnglishVocabulary;component/quizpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\QuizPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.myCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 2:
            this.btnNext = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\QuizPage.xaml"
            this.btnNext.Click += new System.Windows.RoutedEventHandler(this.btnNext_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnResult = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\QuizPage.xaml"
            this.btnResult.Click += new System.Windows.RoutedEventHandler(this.btnResult_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.image2 = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.image1 = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.testWord = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.cbImg1 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 33 "..\..\..\QuizPage.xaml"
            this.cbImg1.Checked += new System.Windows.RoutedEventHandler(this.Answer);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cbImg2 = ((System.Windows.Controls.RadioButton)(target));
            
            #line 37 "..\..\..\QuizPage.xaml"
            this.cbImg2.Checked += new System.Windows.RoutedEventHandler(this.Answer);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
