using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace GestorLigaEV2
{

    // Constructor del objeto tipo Jugador
    public class Jugador
    {
        // Atributos con getters y setters:
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public string? Apodo { get; set; }
        public int Edad {  get; set; }
        public int Dorsal {  get; set; }
        public string? Nacionalidad { get; set; }
        public Equipo? Equipo { get; set; }
        public BitmapImage? Imagen { get; set; }

    }
}
