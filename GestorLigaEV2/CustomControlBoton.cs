using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestorLigaEV2
{
    // CustomControl que hereda de la clase botón (siguiendo el ejemplo de la teoría):
    public class CustomControlBoton : Button
    {
        static CustomControlBoton()
        {
            // Anulamos los metadatos:
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomControlBoton), new
                FrameworkPropertyMetadata(typeof(CustomControlBoton)));
        }
    }
}
