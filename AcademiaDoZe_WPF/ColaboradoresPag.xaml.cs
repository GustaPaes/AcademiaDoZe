using System.Windows;
using System.Windows.Controls;

namespace AcademiaDoZe_WPF
{
    /// <summary>
    /// Interação lógica para ColaboradoresPag.xam
    /// </summary>
    public partial class ColaboradoresPag : Page
    {
        public ColaboradoresPag()
        {
            InitializeComponent(); 
            this.Loaded += Page_Loaded;
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ClassFuncoes.AjustaResources(this);
        }

        private void salvarLog_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Colaborador salvo com successo!");
        }
    }
}
