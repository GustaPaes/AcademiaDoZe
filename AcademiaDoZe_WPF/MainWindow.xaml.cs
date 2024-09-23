using System.Windows;

namespace AcademiaDoZe_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += Page_Loaded;
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ClassFuncoes.AjustaResources(this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Close();
        }
    }
}