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
        // Declaramos una colección observable de jugadores y equipos
        public ObservableCollection<Jugador>? coleccionJugadores { get; set; }

        // A parte de los jugadores también necesitamos en esta parte la colección de Equipos ya
        // que necesitamos no sólo ver sino editar sobre una lista de Equipos ya existente el
        // Equipo del Jugador:
        public ObservableCollection<Equipo>? coleccionEquipos { get; set; }
        public MostrarJugadores(ObservableCollection<Jugador> coleccionJugadores, ObservableCollection<Equipo> coleccionEquipos)
        {
            InitializeComponent();


            // Asignamos las listas recibidas a la local:
            this.coleccionJugadores = coleccionJugadores;
            this.coleccionEquipos = coleccionEquipos;

            // Asignamos al DataContext:
            DataContext = this;

            // Asignamos el origen de los items de Jugador:
            listaJugadores.ItemsSource = coleccionJugadores;
            // A los equipos accedemos directamente desde el xaml
            
        }
    }
}
