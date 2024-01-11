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
    // Main Window

    public partial class MainWindow : Window
    {

        // Declaramos una colección observable de equipos:
        public ObservableCollection<Equipo> coleccionEquipos {get; set;}
        // Declaramos una colección observable de jugadores:
        public ObservableCollection<Jugador> coleccionJugadores {get; set;}

        // Declaramos e inicializamos tres escudos para los tres primeros equipos:
        public Image escVal = new Image();
        public Image escArs = new Image();
        public Image escSab = new Image();

        public MainWindow()
        {
            InitializeComponent();

            // Iniciaizamos la ObservableCollection de Equipos y Jugadores:
            coleccionEquipos = new ObservableCollection<Equipo>();
            coleccionJugadores = new ObservableCollection<Jugador>();

            Equipo valenciaCF = new Equipo { nombre = "Valencia C.F.", fundacion = 1919, estadio = "Mestalla", escudo = escVal };
            Equipo arsenalFC = new Equipo { nombre = "Arsenal F.C.", fundacion = 1886, estadio = "Emirates", escudo = escArs };
            Equipo sabadellCE = new Equipo { nombre = "C.E. Sabadell", fundacion = 1903, estadio = "Nova Creu Alta", escudo = escSab };

            // Añadimos los equipos creados a nuestra colección:
            coleccionEquipos.Add(valenciaCF);
            coleccionEquipos.Add(arsenalFC);
            coleccionEquipos.Add(sabadellCE);

            // Ahora creamos varios jugadores:
            Jugador davidVilla = new Jugador { nombre = "David", apellidos = "Villa Sánchez", apodo = "El Guaje", edad = 42, dorsal = 7, nacionalidad = "Española", equipo = valenciaCF };
            Jugador thierryHenry = new Jugador { nombre = "Thierry", apellidos = "Henry", apodo = "Tití", edad = 46, dorsal = 14, nacionalidad = "Francesa", equipo = arsenalFC };
            Jugador juvenalEdjogo = new Jugador { nombre = "Juvenal", apellidos = "Edjogo Owono Montalbán", apodo = "Juve", edad = 44, dorsal = 6, nacionalidad = "Ecuatoguineano", equipo = sabadellCE };

            // Añadimos los jugadores a nuestra colección:
            coleccionJugadores.Add(davidVilla);
            coleccionJugadores.Add(thierryHenry);
            coleccionJugadores.Add(juvenalEdjogo);


            DataContext = this;

        }

        // Métodos para manejar la funcionalidad de los botones:

        // Click en la opción de Crear Jugador:
        private void crearJugador_Click(object sender, RoutedEventArgs e)
        {

        }

        // Click en la opción de Crear Equipo:
        private void crearEquipo_Click(object sender, RoutedEventArgs e)
        {

        }

        // Click en la opción de Mostrar Jugadores:
        private void mostrarJugadores_Click(object sender, RoutedEventArgs e)
        {

        }

        // Click en la opción de Mostrar Equipos:
        private void mostrarEquipos_Click(object sender, RoutedEventArgs e)
        {
            // TODO:

            // Inicializamos la vista:
            //new MostrarEquipos(coleccionEquipos);
            // Cambiamos el frame:

        }

        // Click en la autoría:
        private void acercaDe_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
