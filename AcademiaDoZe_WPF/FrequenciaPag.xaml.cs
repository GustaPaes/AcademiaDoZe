﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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

            this.Loaded += Page_Loaded;
            this.PreviewKeyDown += new KeyEventHandler(ClassFuncoes.Window_KeyDown);
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ClassFuncoes.AjustaResources(this);        
        }

        private void salvarFreqClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Frquência salva com sucesso!");
        }
    }
}
