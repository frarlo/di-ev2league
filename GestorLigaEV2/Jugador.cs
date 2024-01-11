using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorLigaEV2
{

    // Constructor del objeto tipo Jugador
    public class Jugador
    {
        // Atributos con getters y setters:
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string apodo { get; set; }
        public int edad {  get; set; }
        public int dorsal {  get; set; }
        public string nacionalidad { get; set; }
        public Equipo equipo { get; set; }

    }
}
