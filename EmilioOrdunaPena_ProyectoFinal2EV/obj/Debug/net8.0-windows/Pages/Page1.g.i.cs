﻿#pragma checksum "..\..\..\..\Pages\Page1.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E8D4846240633DD6629185C2D844ACAC957942E2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using EmilioOrdunaPena_ProyectoFinal2EV.Pages;
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


namespace EmilioOrdunaPena_ProyectoFinal2EV.Pages {
    
    
    /// <summary>
    /// Page1
    /// </summary>
    public partial class Page1 : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 57 "..\..\..\..\Pages\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAgregarRegistro;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\Pages\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox listaCategorias;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\Pages\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem catPorDefecto;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\..\..\Pages\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid tablaProductos;
        
        #line default
        #line hidden
        
        
        #line 175 "..\..\..\..\Pages\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtBuscar;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\..\..\Pages\Page1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnBuscar;
        
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
            System.Uri resourceLocater = new System.Uri("/EmilioOrdunaPena_ProyectoFinal2EV;component/pages/page1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Page1.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
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
            this.btnAgregarRegistro = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\..\Pages\Page1.xaml"
            this.btnAgregarRegistro.Click += new System.Windows.RoutedEventHandler(this.btnAgregarRegistro_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.listaCategorias = ((System.Windows.Controls.ComboBox)(target));
            
            #line 86 "..\..\..\..\Pages\Page1.xaml"
            this.listaCategorias.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listaCategorias_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.catPorDefecto = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 4:
            this.tablaProductos = ((System.Windows.Controls.DataGrid)(target));
            
            #line 159 "..\..\..\..\Pages\Page1.xaml"
            this.tablaProductos.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.tablaProductos_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtBuscar = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnBuscar = ((System.Windows.Controls.Button)(target));
            
            #line 179 "..\..\..\..\Pages\Page1.xaml"
            this.btnBuscar.Click += new System.Windows.RoutedEventHandler(this.btnBuscar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

