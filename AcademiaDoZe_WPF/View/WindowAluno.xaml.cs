using AcademiaDoZe_WPF.ViewModel;
using System.Windows;

namespace AcademiaDoZe_WPF.View
{
    /// <summary>
    /// Lógica interna para WindowAluno.xaml
    /// </summary>
    public partial class WindowAluno : Window
    {
        public WindowAluno()
        {
            InitializeComponent();

            DataContext = new AlunoCadastroViewModel();
        }
    }
}
