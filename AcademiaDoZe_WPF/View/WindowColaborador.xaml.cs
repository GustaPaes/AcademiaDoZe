using AcademiaDoZe_WPF.ViewModel;
using System.Windows;

namespace AcademiaDoZe_WPF.View
{
    /// <summary>
    /// Lógica interna para WindowColaborador.xaml
    /// </summary>
    public partial class WindowColaborador : Window
    {
        public WindowColaborador()
        {
            InitializeComponent();

            DataContext = new ColaboradorCadastroViewModel();
        }
    }
}
