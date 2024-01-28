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

        // El método que construye la vista recoge como parámetro nuestra lista de equipos:
        public CreacionEquipo(ObservableCollection<Equipo> coleccionEquipos)
        {
            InitializeComponent();

            // Asignamos la lista recibida a la local:
            this.coleccionEquipos = coleccionEquipos;
            DataContext = this;

        }

        // Método que recoge el Click para borrar todos los campos introducidos:
        private void BorrarCampos_Click(object sender, RoutedEventArgs e)
        {
            // Invocamos el método para despejar todos los datos introducidos:
            BorrarCampos();
        }

        // Método que vacía los TextBox:
        public void BorrarCampos()
        {
            // Despejamos todos los datos introducidos
            nombreEquipo.Text = "";
            añoFundacion.Text = "";
            estadioEquipo.Text = "";
            rutaArchivoSeleccionado = null;
        }

        // Método que recoge el Click de crear equipo:
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
                MessageBox.Show("El equipo se ha creado y añadido a la colección", "Operación realizada", MessageBoxButton.OK, MessageBoxImage.Information);
                
                // Despejamos los campos:
                BorrarCampos();
            }
            // Si el usuario no ha introducido todos los datos (falta algo)...
            else
            {
                // Diálogo para informarle:
                MessageBox.Show("El equipo no se ha creado, faltan datos.", "Operación no realizada", MessageBoxButton.OK, MessageBoxImage.Error);
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
            }

        }

        /* Método para implementar PreviewTextInput https://stackoverflow.com/q/1226128/14441036
        Nos permite comprobar lo que el usuario introduce en el TextBox y obviarlo si es necesario
        Aquí lo hemos utilizado tanto para obviar cadenas de letras en los TextBox que van a recibir
        un valor numérico como para los que reciben solamente una cadena y no números */
        private void TextBoxNumber(object sender, TextCompositionEventArgs e)
        {
            // Accedemos a lo introducido:
            String input = e.Text;
            // Si no es un dígito...
            if (!input.All(char.IsDigit))
            {
                // Lo manejamos (no dejamos que se introduzca)
                e.Handled = true;
            }
        }

        private void TextBoxChar(object sender, TextCompositionEventArgs e)
        {
            String input = e.Text;
            // Si es un dígito...
            if (input.All(char.IsDigit))
            {
                // Lo manejamos de igual forma.
                e.Handled = true;
            }
        }
    }
}
