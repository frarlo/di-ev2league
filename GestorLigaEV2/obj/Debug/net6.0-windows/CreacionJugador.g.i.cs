﻿#pragma checksum "..\..\..\CreacionJugador.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06739545E0F50BAA2CF7E8CFE20F12BBEF901F45"
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
    /// CreacionJugador
    /// </summary>
    public partial class CreacionJugador : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\CreacionJugador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nombreJugador;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\CreacionJugador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox apellidosJugador;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\CreacionJugador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox apodoJugador;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\CreacionJugador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox edadJugador;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\CreacionJugador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox dorsalJugador;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\CreacionJugador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nacionalidadJugador;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\CreacionJugador.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox equipoJugador;
        
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
            System.Uri resourceLocater = new System.Uri("/GestorLigaEV2;component/creacionjugador.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\CreacionJugador.xaml"
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
            this.nombreJugador = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.apellidosJugador = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.apodoJugador = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.edadJugador = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.dorsalJugador = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.nacionalidadJugador = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.equipoJugador = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            
            #line 45 "..\..\..\CreacionJugador.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SeleccionarArchivo_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 46 "..\..\..\CreacionJugador.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BorrarCampos_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 47 "..\..\..\CreacionJugador.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CrearJugador_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

