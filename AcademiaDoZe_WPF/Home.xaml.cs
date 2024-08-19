using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AcademiaDoZe_WPF
{
    /// <summary>
    /// Lógica interna para Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void LOGOUT_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Logradourobtn_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new LogradouroPag());
        }

        private void AlunoBtn_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new  AlunoPag());
        }

        private void ColaboradorBtn_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new ColaboradoresPag());
        }

        private void SenhaBtn_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate (new SenhaPag());
        }

        private void Matriculabtn_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new MatriculaPag());
        }

        private void AvaliacaoBtn_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new AvaliacoesPag());
        }

        private void FrequenciaBtn_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new FrequenciaPag());
        }
    }
}
