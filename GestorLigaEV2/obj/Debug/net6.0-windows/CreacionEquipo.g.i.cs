﻿#pragma checksum "..\..\..\CreacionEquipo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DA38CC37EF88664550038C6993A8D04E1A0BE701"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using GestorLigaEV2;
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


namespace GestorLigaEV2 {
    
    
    /// <summary>
    /// CreacionEquipo
    /// </summary>
    public partial class CreacionEquipo : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 33 "..\..\..\CreacionEquipo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nombreEquipo;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\CreacionEquipo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox añoFundacion;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\CreacionEquipo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox estadioEquipo;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\CreacionEquipo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GestorLigaEV2.CustomControlBoton CustomControlBoton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GestorLigaEV2;component/creacionequipo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CreacionEquipo.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.nombreEquipo = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\CreacionEquipo.xaml"
            this.nombreEquipo.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextBoxChar);
            
            #line default
            #line hidden
            return;
            case 2:
            this.añoFundacion = ((System.Windows.Controls.TextBox)(target));
            
            #line 37 "..\..\..\CreacionEquipo.xaml"
            this.añoFundacion.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextBoxNumber);
            
            #line default
            #line hidden
            return;
            case 3:
            this.estadioEquipo = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\..\CreacionEquipo.xaml"
            this.estadioEquipo.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextBoxChar);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 45 "..\..\..\CreacionEquipo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SeleccionarArchivo_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 47 "..\..\..\CreacionEquipo.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BorrarCampos_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CustomControlBoton = ((GestorLigaEV2.CustomControlBoton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

