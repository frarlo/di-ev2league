using Microsoft.Win32;
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
        public ObservableCollection<Jugador> coleccionJugadores { get; set; }

        // A parte de los jugadores también necesitamos en esta parte la colección de Equipos ya
        // que necesitamos no sólo ver sino editar sobre una lista de Equipos ya existente el
        // Equipo del Jugador:
        public ObservableCollection<Equipo> coleccionEquipos { get; set; }

        // Declaramos aquí la ruta de la imagen por si el usuario quiere editar alguna idem:
        string rutaArchivoSeleccionado;

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

        private void botonEliminar_Click(object sender, RoutedEventArgs e)
        {

            // Comprobamos si hay algún jugador seleccionado:
            if(listaJugadores.SelectedItem != null)
            {
                // Hay alguno, así que sacamos el jugador seleccionado:
                Jugador jugadorSeleccionado = (Jugador)listaJugadores.SelectedItem;

                // Lo eliminamos:
                coleccionJugadores.Remove(jugadorSeleccionado);

                // Refrescamos la vista:
                listaJugadores.Items.Refresh();
            }
        }

        // Botón que recoge la edición de la imagen:
        private void botonCambiarImagen_Click(object sender, RoutedEventArgs e)
        {
            // Comprobamos que se haya seleccionado algún elemento:
            if(listaJugadores.SelectedItem != null)
            {
                // Hay alguno, así que scamos el jugador seleccionado:
                Jugador jugadorSeleccionado = (Jugador)listaJugadores.SelectedItem;

                // Pedimos la nueva imagen:
                // Inicializamos un dialogo de archivo:
                OpenFileDialog openFileDialog = new OpenFileDialog();

                // Título y filtro:
                openFileDialog.Title = "Selecciona una imagen";
                openFileDialog.Filter = "Imagen jpg (*.jpg)|*.jpg|Imagen png (*.png)|*.png";

                // Inicializamos un valor boooleano al mostrar el diálogo:
                bool? resultado = openFileDialog.ShowDialog();

                // Si el usuario introduce un archivo correcto...
                if (resultado == true)
                {
                    // Accedemos a la ruta del archivo seleccionado:
                    rutaArchivoSeleccionado = openFileDialog.FileName;
                    // Cambiamos la imagen del jugador:
                    jugadorSeleccionado.Imagen = new BitmapImage(new Uri(rutaArchivoSeleccionado, UriKind.RelativeOrAbsolute));

                    // Y finalmente refrescamos la vista para que se muestre:
                    listaJugadores.Items.Refresh();
                }
                


            }

        }
    }
}
