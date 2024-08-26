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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AcademiaDoZe_WPF
{
    /// <summary>
    /// Interação lógica para FrequenciaPag.xam
    /// </summary>
    public partial class FrequenciaPag : Page
    {
        public FrequenciaPag()
        {
            InitializeComponent();
            this.Loaded += Page_Loaded; this.Loaded += Page_Loaded;
        }

        private void salvarMat_Click(object sender, RoutedEventArgs e)
        {

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
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ClassFuncoes.AjustaResources(this);
        }
    }
}
