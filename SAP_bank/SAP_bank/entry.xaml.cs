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

namespace SAP_bank
{
    /// <summary>
    /// Логика взаимодействия для entry.xaml
    /// </summary>
    public partial class entry : Window
    {
        public entry()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void entryButton_Click(object sender, RoutedEventArgs e)
        {
            
            workplace work = new workplace();
            work.ShowDialog();
        }
    }
}
