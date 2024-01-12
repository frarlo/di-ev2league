using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace GestorLigaEV2
{
    // Constructor del objeto tipo Equipo
    public class Equipo : INotifyPropertyChanged
    {
        
        // Atributos con getters y setters:
        public string? Nombre { get; set; }
        public int Fundacion { get; set; }
        public string? Estadio { get; set; }
        public BitmapImage? Escudo { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
