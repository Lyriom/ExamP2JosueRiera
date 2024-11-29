using ExamP2JosueRiera;
using System;
using System.IO;

namespace EXAMP2
{
    public partial class StackLayoutPage : ContentPage
    {
        private readonly string archivoRecarga;

        public StackLayoutPage()
        {
            InitializeComponent();
            archivoRecarga = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "JosueRiera.txt");
            CargarUltimaRecarga();
        }

        private void CargarUltimaRecarga()
        {
            if (File.Exists(archivoRecarga))
            {
                string ultimaRecarga = File.ReadAllText(archivoRecarga);
                jr_resultadoLabel.Text = $"Última recarga realizada:\n{ultimaRecarga}";
            }
        }

        private void jr_recargaButton_Clicked(object sender, EventArgs e)
        {
            string nombre = jr_nombreEntry.Text;
            string telefono = jr_telefonoEntry.Text;


            string recargaInfo = $"Nombre: {nombre}\nTeléfono: {telefono}\nFecha: {DateTime.Now:yyyy-MM-dd HH:mm:ss}";
            File.WriteAllText(archivoRecarga, recargaInfo);

            

            jr_nombreEntry.Text = string.Empty;
            jr_telefonoEntry.Text = string.Empty;
            CargarUltimaRecarga();
        }
        private void IrAGrid(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageGrid());
        }
    }
}
