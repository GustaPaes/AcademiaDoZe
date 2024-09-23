using System.Windows;
using System.Windows.Controls;

namespace AcademiaDoZe_WPF
{
    /// <summary>
    /// Lógica interna para MatriculaPag.xaml
    /// </summary>
    public partial class MatriculaPag : Page
    {
        public MatriculaPag()
        {
            InitializeComponent();
            this.Loaded += Page_Loaded;
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ClassFuncoes.AjustaResources(this);
        }

        private void salvarMat_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Matrícula salva com sucesso!");
        }
    }
}
