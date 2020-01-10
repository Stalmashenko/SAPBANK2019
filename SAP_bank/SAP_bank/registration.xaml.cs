using SAP_bank.Models;
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
    public partial class registration : Window
    {
        public registration()
        {
            InitializeComponent();
        }

        private void first_Expanded(object sender, RoutedEventArgs e)
        {
            //if (second.IsExpanded)
            //{
            //    first.IsExpanded = false;
            //};
        }

        private void second_Expanded(object sender, RoutedEventArgs e)
        {
        //    if (first.IsExpanded)
        //    {
        //        second.IsExpanded = false;
        //    };
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            USERS User = new USERS()
            {
                LOGIN = "Nastya", PASSWORD = "1234"
            };

            ADDRESS Adress = new ADDRESS()
            {
                CITY = "Минск",
                FLAT = 33,
                HOUSE = "2",
                HOUSING = "-",
                STREET = "Яна Чечота",
                STATE = "Беларусь"
            };

            CLIENTS Client = new CLIENTS()
            {
                FIRSTNAME = "Настя",
                FATHERSNAME = "Павловна",
                BDAY = DateTime.Now,
                GENDER = "ж",
                PHONE = "37544429181",
                ID_PASSPORT = "2131231231231",
                SURNAME = "Стальмашенко",
                ADDRESS = Adress,
            };
            Client.USERS.Add(User);
            //BALANCE Bal = new BALANCE()
            //{
            //    Bal
            //}
            using (Context db = new Context())
            {
                db.CLIENTS.Add(Client);
                db.SaveChanges();
            }
            Close();
            workplace work = new workplace();
            work.ShowDialog();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
