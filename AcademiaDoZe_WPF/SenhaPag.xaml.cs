using System.Windows;
using System.Windows.Controls;

namespace AcademiaDoZe_WPF
{
    /// <summary>
    /// Interação lógica para SenhaPag.xam
    /// </summary>
    public partial class SenhaPag : Page
    {
        public SenhaPag()
        {
            InitializeComponent();
            this.Loaded += Page_Loaded;
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ClassFuncoes.AjustaResources(this);
        }

        private void salvarSen_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Senha salva com successo!");
        }
    }
}
