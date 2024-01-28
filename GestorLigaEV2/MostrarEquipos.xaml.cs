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

    public partial class MostrarEquipos : Page
    {
        // Declaramos una colección observable de equipos:
        public ObservableCollection<Equipo>? ColeccionEquipos { get; set; }

        // Declaramos aquí la ruta de la imagen por si el usuario quiere editar alguna idem:
        string rutaArchivoSeleccionado;

        public MostrarEquipos(ObservableCollection<Equipo> coleccionEquipos)
        {
            InitializeComponent();

            // Asignamos la lista recibida a la local:
            this.ColeccionEquipos = coleccionEquipos;
            DataContext = this;

            // Llenamos el DataGrid con nuestra colección observable:
            listaEquipos.ItemsSource = coleccionEquipos;
        }

        // Botón para recoger el click de eliminar:
        private void botonEliminar_Click(object sender, RoutedEventArgs e)
        {
            // Comprobamos si hay algún equipo seleccionado:
            if(listaEquipos.SelectedItem != null)
            {

                // Creamos un result de la MessageBox avisando del borrado:
                MessageBoxResult result = MessageBox.Show("Borrar el equipo es irreversible. ¿Seguro que quiere hacerlo?", "Operación irreversible", MessageBoxButton.YesNo, MessageBoxImage.Information);

                if (result == MessageBoxResult.Yes)
                {
                    // Obtenemos el equipo seleccionado de nuestro DataGrid:
                    Equipo equipoSeleccionado = (Equipo)listaEquipos.SelectedItem;

                    // Lo eliminamos:
                    ColeccionEquipos.Remove(equipoSeleccionado);

                    // Actualizamos la vista:
                    listaEquipos.Items.Refresh();
                }

                // Si el usuario hace clic en "No" no hacemos nada.

            }

            // Si no hay ningún equipo seleccionado el botón no hace nada.

        }

        // Botón que recoge la edición del escudo
        private void botonCambiarImagen_Click(object sender, RoutedEventArgs e)
        {
            // Comprobamos que se haya seleccionado algún elemento:
            if (listaEquipos.SelectedItem != null)
            {
                // Hay alguno, así que scamos el jugador seleccionado:
                Equipo equipoSeleccionado = (Equipo)listaEquipos.SelectedItem;

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
                    equipoSeleccionado.Escudo = new BitmapImage(new Uri(rutaArchivoSeleccionado, UriKind.RelativeOrAbsolute));

                    // Y finalmente refrescamos la vista para que se muestre:
                    listaEquipos.Items.Refresh();
                }
            }
        }
    }
}
