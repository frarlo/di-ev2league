using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace GestorLigaEV2
{
    /// <summary>
    /// Lógica de interacción para CreacionJugador.xaml
    /// </summary>
    public partial class CreacionJugador : Page
    {
        // Declaramos una colección observable de jugadores y equipos
        public ObservableCollection<Jugador>? coleccionJugadores { get; set; }

        // A parte de los jugadores también necesitamos en esta parte la colección de Equipos ya
        // que necesitamos no sólo ver sino editar sobre una lista de Equipos ya existente el
        // Equipo del Jugador:
        public ObservableCollection<Equipo>? coleccionEquipos { get; set; }

        // Declaramos aquí la ruta de la imagen:
        string rutaArchivoSeleccionado;
        public CreacionJugador(ObservableCollection<Jugador> coleccionJugadores, ObservableCollection<Equipo> coleccionEquipos)
        {
            InitializeComponent();
            InitializeComponent();


            // Asignamos las listas recibidas a la local:
            this.coleccionJugadores = coleccionJugadores;
            this.coleccionEquipos = coleccionEquipos;

            // Asignamos al DataContext:
            DataContext = this;
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
            if (resultado == true)
            {
                // Accedemos a la ruta del archivo seleccionado:
                rutaArchivoSeleccionado = openFileDialog.FileName;

                // Copiamos a nuestro directorio de imágenes:

                // Redimensionamos:

                // La asignamos a nuestra variable:


            }
        }

        private void BorrarCampos_Click(object sender, RoutedEventArgs e)
        {
            // Invocamos el método para despejar todos los datos introducidos:
            BorrarCampos();
        }

        public void BorrarCampos()
        {
            // Despejamos todos los datos introducidos
            nombreJugador.Text = "";
            apellidosJugador.Text = "";
            apodoJugador.Text = "";
            edadJugador.Text = "";
            dorsalJugador.Text = "";
            nacionalidadJugador.Text = "";
            equipoJugador.Text = "";
            rutaArchivoSeleccionado = null;
        }


        private void CrearJugador_Click(object sender, RoutedEventArgs e)
        {
            // Si el usuario ha introducido los datos correctos...
            if (DatosIntroducidosCorrectos())
            {
                // Parseamos la edad introducida por el usuario a int
                int edad = int.Parse(edadJugador.Text);
                // Lo mismo con el dorsal:
                int dorsal = int.Parse(dorsalJugador.Text);

                // Accedemos al equipo seleccionado:
                Equipo equipoSeleccionado = (Equipo)equipoJugador.SelectedItem;

                // Creamos el nuevo jugador:
                Jugador nuevoJugador = new Jugador
                {
                    Nombre = nombreJugador.Text,
                    Apellidos = apellidosJugador.Text,
                    Apodo = apodoJugador.Text,
                    Edad = edad,
                    Dorsal = dorsal,
                    Nacionalidad = nacionalidadJugador.Text,
                    EquipoSel = equipoSeleccionado,
                    Imagen = new BitmapImage(new Uri(rutaArchivoSeleccionado, UriKind.RelativeOrAbsolute))
                };

                // Lo añadimos a nuestra colección:

                coleccionJugadores.Add(nuevoJugador);

                // Avisamos:
                MessageBox.Show("Jugador creado y añadido a la colección.");

                // Despejamos los campos:
                BorrarCampos();
            }
        }


        public bool DatosIntroducidosCorrectos()
        {

            // Comprobamos que todos los campos introducibles tienen valor...
            if (nombreJugador.Text != "" && apellidosJugador.Text != "" && apodoJugador.Text != ""
                    && edadJugador.Text != "" && dorsalJugador.Text != ""
                    && nacionalidadJugador.Text != "" && equipoJugador.Text != ""
                    && rutaArchivoSeleccionado != null)
            {
                // Parseamos los datos numéricos:
                // Parseamos la edad introducida por el usuario a int
                int edad = int.Parse(edadJugador.Text);
                // Lo mismo con el dorsal:
                int dorsal = int.Parse(dorsalJugador.Text);

                if (edad < 18 || edad > 99)
                {
                    MessageBox.Show("El jugador tiene que ser mayor de edad o no estar con un pie en la tumba...");
                    return false;
                }
                else if (dorsal < 1 || dorsal > 99)
                {
                    MessageBox.Show("Un dorsal debe ser un número entre 1 y 99 (incluidos)...");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Faltan campos por introducir.");
                return false;
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
