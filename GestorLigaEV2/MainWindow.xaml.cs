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

        /****
         * 
         * 
         * 
         *   HAY QUE PERMITIR LA EDICIÓN TAMBIÉN!!
         * 
         * 
         * **/

        // Declaramos una colección observable de equipos:
        public ObservableCollection<Equipo> coleccionEquipos {get; set;}
        // Declaramos una colección observable de jugadores:
        public ObservableCollection<Jugador> coleccionJugadores {get; set;}

        // Declaramos e inicializamos tres escudos para los tres primeros equipos:
        public BitmapImage escVal = new BitmapImage(new Uri("Recursos/escVal.jpg", UriKind.RelativeOrAbsolute));
        public BitmapImage escArs = new BitmapImage(new Uri("Recursos/escArs.png", UriKind.RelativeOrAbsolute));
        public BitmapImage escSab = new BitmapImage(new Uri("Recursos/escSab.jpg", UriKind.RelativeOrAbsolute));

        public MainWindow()
        {
            InitializeComponent();

            // Iniciaizamos la ObservableCollection de Equipos y Jugadores:
            coleccionEquipos = new ObservableCollection<Equipo>();
            coleccionJugadores = new ObservableCollection<Jugador>();

            Equipo valenciaCF = new Equipo { Nombre = "Valencia C.F.", Fundacion = 1919, Estadio = "Mestalla", Escudo = escVal };
            Equipo arsenalFC = new Equipo { Nombre = "Arsenal F.C.", Fundacion = 1886, Estadio = "Emirates", Escudo = escArs };
            Equipo sabadellCE = new Equipo { Nombre = "C.E. Sabadell", Fundacion = 1903, Estadio = "Nova Creu Alta", Escudo = escSab };

            // Añadimos los equipos creados a nuestra colección:
            coleccionEquipos.Add(valenciaCF);
            coleccionEquipos.Add(arsenalFC);
            coleccionEquipos.Add(sabadellCE);

            // Ahora creamos varios jugadores:
            Jugador davidVilla = new Jugador { Nombre = "David", Apellidos = "Villa Sánchez", Apodo = "El Guaje", Edad = 42, Dorsal = 7, Nacionalidad = "Española", Equipo = valenciaCF, Imagen = null };
            Jugador thierryHenry = new Jugador { Nombre = "Thierry", Apellidos = "Henry", Apodo = "Tití", Edad = 46, Dorsal = 14, Nacionalidad = "Francesa", Equipo = arsenalFC, Imagen = null };
            Jugador juvenalEdjogo = new Jugador { Nombre = "Juvenal", Apellidos = "Edjogo Owono Montalbán", Apodo = "Juve", Edad = 44, Dorsal = 6, Nacionalidad = "Ecuatoguineano", Equipo = sabadellCE, Imagen = null };

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

            MostrarJugadores vistaMuestraJugadores = new MostrarJugadores(coleccionJugadores);

            contenedorPaginas.Content = vistaMuestraJugadores;

        }

        // Click en la opción de Mostrar Equipos:
        private void mostrarEquipos_Click(object sender, RoutedEventArgs e)
        {
            // TODO:

            // Inicializamos la vista:
            MostrarEquipos vistaMuestraEquipos = new MostrarEquipos(coleccionEquipos);
            // Cambiamos el ContentTemplate
            contenedorPaginas.Content = vistaMuestraEquipos;

        }

        // Click en la autoría:
        private void acercaDe_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
