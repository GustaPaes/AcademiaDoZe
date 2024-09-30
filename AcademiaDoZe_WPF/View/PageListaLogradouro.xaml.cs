using AcademiaDoZe_WPF.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace AcademiaDoZe_WPF.View
{
    /// <summary>
    /// Interação lógica para PageListaLogradouro.xam
    /// </summary>
    public partial class PageListaLogradouro : Page
    {
        private string ConnectionString { get; set; }

        private string ProviderName { get; set; }

        private LogradouroViewModel ViewModelLogradouro;

        public PageListaLogradouro(string providerName, string connectionString)
        {
            InitializeComponent();

            ConnectionString = connectionString;
            ProviderName = providerName;

            try
            {
                // criação de objeto ViewModel
                ViewModelLogradouro = new LogradouroViewModel(ProviderName, ConnectionString);
                // carrega os dados
                ViewModelLogradouro.Load();
                // associa o objeto da ViewModel ao DataContext da janela
                // DataContext é uma propriedade que permite que elementos de interface gráfica sejam associados a objetos de dados
                DataContext = ViewModelLogradouro;
            }
            catch
            {
                MessageBox.Show("Erro ao carregar a lista de logradouros!");
            }
        }
        private void ButtonNovo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new LogradouroPag());
            //NavigationService?.Navigate(new LogradouroPag(ProviderName, ConnectionString));
        }
    }
}