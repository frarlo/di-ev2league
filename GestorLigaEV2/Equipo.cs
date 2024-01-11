using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace GestorLigaEV2
{
    // Constructor del objeto tipo Equipo
    public class Equipo
    {
        // Atributos con getters y setters:
        public string nombre { get; set; }
        public int fundacion { get; set; }
        public string estadio { get; set; }
        public Image escudo { get; set; }
    }
}
