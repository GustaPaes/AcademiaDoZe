using System.Windows;
using System.Windows.Controls;

namespace AcademiaDoZe_WPF
{
    /// <summary>
    /// Interação lógica para LogradouroPag.xam
    /// </summary>
    public partial class LogradouroPag : Page
    {
        public LogradouroPag()
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
            MessageBox.Show("Logradouro salvo com successo!");
        }
    }
}
