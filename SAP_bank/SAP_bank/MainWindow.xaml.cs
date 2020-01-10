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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SAP_bank
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            registration regis = new registration();
            regis.ShowDialog();
        }

        private void EntryButton_Click(object sender, RoutedEventArgs e)
        {
            
            entry entry = new entry();
            entry.ShowDialog();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
