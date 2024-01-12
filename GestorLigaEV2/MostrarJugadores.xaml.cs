using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// <summary>
    /// Lógica de interacción para MostrarJugadores.xaml
    /// </summary>
    public partial class MostrarJugadores : Page
    {
        // Declaramos una colección observable de equipos:
        public ObservableCollection<Jugador>? coleccionJugadores { get; set; }
        public MostrarJugadores(ObservableCollection<Jugador> coleccionJugadores)
        {
            InitializeComponent();


            // Asignamos la lista recibida a la local:
            this.coleccionJugadores = coleccionJugadores;

            DataContext = this;

            listaJugadores.ItemsSource = coleccionJugadores;
        }
    }
}
