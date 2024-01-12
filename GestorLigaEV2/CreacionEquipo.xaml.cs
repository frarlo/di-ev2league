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
    /// Lógica de interacción para CreacionEquipo.xaml
    /// </summary>
    public partial class CreacionEquipo : Page
    {
        // Declaramos una colección observable de equipos:
        public ObservableCollection<Equipo> coleccionEquipos { get; set; }

        // Declaramos aquí la ruta de la imagen:
        string rutaArchivoSeleccionado;
        public CreacionEquipo(ObservableCollection<Equipo> coleccionEquipos)
        {
            InitializeComponent();


            // Asignamos la lista recibida a la local:
            this.coleccionEquipos = coleccionEquipos;

            DataContext = this;

        }

        private void BorrarCampos_Click(object sender, RoutedEventArgs e)
        {
            // Invocamos el método para despejar todos los datos introducidos:
            BorrarCampos();
        }

        public void BorrarCampos()
        {
            // Despejamos todos los datos introducidos
            nombreEquipo.Text = "";
            añoFundacion.Text = "";
            estadioEquipo.Text = "";
            rutaArchivoSeleccionado = null;
        }

        private void CrearEquipo_Click(object sender, RoutedEventArgs e)
        {
            // Si el usuario ha introducido todos los datos y la imagen...
            if(nombreEquipo.Text != "" && añoFundacion.Text != "" && estadioEquipo.Text != "" 
                && rutaArchivoSeleccionado != null)
            {
                // Parseamos el año introducido por el usuario a int
                int año = int.Parse(añoFundacion.Text);

                // Creamos un objeto Equipo con los datos recibidos...
                Equipo nuevoEquipo = new Equipo
                {
                    Nombre = nombreEquipo.Text,
                    Fundacion = año,
                    Estadio = estadioEquipo.Text,
                    Escudo = new BitmapImage(new Uri(rutaArchivoSeleccionado, UriKind.RelativeOrAbsolute))
                };

                // Y lo añadimos a nuestra Observable Collection:
                coleccionEquipos.Add(nuevoEquipo);

                // Avisamos:
                MessageBox.Show("Equipo creado y añadido a la colección.");

                // Despejamos los campos:
                BorrarCampos();
            }
            // Si el usuario no ha introducido todos los datos (falta algo)...
            else
            {
                // Diálogo para informarle:
                MessageBox.Show("No has introducido todos los datos necesarios...");
            }

        }

        private void SeleccionarArchivo_Click(object sender, RoutedEventArgs e)
        {
            // Inicializamos un dialogo de archivo:
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Título y filtro:
            openFileDialog.Title = "Selecciona una imagen";
            openFileDialog.Filter = "Imagen jpg (*.jpg)|*.jpg|Imagen png (*.png)|*.png";

            // Inicializamos un valor boooleano al mostrar el diálogo:
            bool? resultado = openFileDialog.ShowDialog();

            // Si el usuario introduce un archivo correcto...
            if(resultado == true)
            {
                // Accedemos a la ruta del archivo seleccionado:
                rutaArchivoSeleccionado = openFileDialog.FileName;

                // Copiamos a nuestro directorio de imágenes:

                // Redimensionamos:

                // La asignamos a nuestra variable:


            }

        }
    }
}
