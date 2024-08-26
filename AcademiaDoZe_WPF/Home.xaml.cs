using System;
using System.Collections.Generic;
using System.Globalization;
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

        private void treinosbtn_Copiar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonPortuguese_Click(object sender, RoutedEventArgs e)
        {
            ChangeLanguage("pt-BR");
        }

        private void ButtonEnglish_Click(object sender, RoutedEventArgs e)
        {
            ChangeLanguage("en-US");
        }

        private void ButtonSpanish_Click(object sender, RoutedEventArgs e)
        {
            ChangeLanguage("es-ES");
        }
        private void ChangeLanguage(string cultureCode)
        {
            // en-US, es-ES, pt-BR
            // Definir a cultura
            CultureInfo culture = new CultureInfo(cultureCode);
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            // Recargar a interface do usuário para refletir as mudanças
            var oldWindow = this;
            var newWindow = new MainWindow();
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            oldWindow.Close();
        }
    }
}
