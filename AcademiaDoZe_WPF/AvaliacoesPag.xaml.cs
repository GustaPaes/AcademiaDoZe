using System.Windows;
using System.Windows.Controls;

namespace AcademiaDoZe_WPF
{
    /// <summary>
    /// Interação lógica para AvaliacoesPag.xam
    /// </summary>
    public partial class AvaliacoesPag : Page
    {
        public AvaliacoesPag()
        {
            InitializeComponent(); 
            this.Loaded += Page_Loaded;
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ClassFuncoes.AjustaResources(this);
        }

        private void salvarAva_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Avaliação salva com sucesso!");
        }

    }
}
