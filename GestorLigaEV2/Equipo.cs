using System.ComponentModel;
using System.Windows.Media.Imaging;

namespace GestorLigaEV2
{
    // Constructor del objeto tipo Equipo con la implementación de "INotifyPropertyChanges" de Data Binding:
    public class Equipo : INotifyPropertyChanged
    {
        
        // Atributos con getters y setters:
        public string? Nombre { get; set; }
        public int Fundacion { get; set; }
        public string? Estadio { get; set; }
        public BitmapImage? Escudo { get; set; }

        // Declaración del PropertyChanged:
        public event PropertyChangedEventHandler? PropertyChanged;

        // Si cambia alguna propiedad lanza el aviso:
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
