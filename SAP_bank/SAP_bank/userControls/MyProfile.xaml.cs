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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SAP_bank.userControls
{
    /// <summary>
    /// Логика взаимодействия для MyProfile.xaml
    /// </summary>
    public partial class MyProfile : UserControl
    {
        public MyProfile()
        {
            InitializeComponent();
            using (Context db = new Context())
            {
                var client = db.CLIENTS.Find(1);
                MyProfileBDAY.Text = client.BDAY.ToShortDateString();
            }
        }

        private void MyProfileButton_Change_Click(object sender, RoutedEventArgs e)
        {
            MyProfileButton_Save.Visibility = Visibility.Visible;
            MyProfileSurname.IsReadOnly = false;
            MyProfileFirstname.IsReadOnly = false;
            MyProfileFathersname.IsReadOnly = false;
            MyProfilePhone.IsReadOnly = false;

            MyProfileState.IsReadOnly = false;
            MyProfileCity.IsReadOnly = false;
            MyProfileStreet.IsReadOnly = false;
            MyProfileHouse.IsReadOnly = false;
            MyProfileHousing.IsReadOnly = false;
            MyProfileFlat.IsReadOnly = false;
        }

        private void MyProfileButton_Save_Click(object sender, RoutedEventArgs e)
        {
            MyProfileSurname.IsReadOnly = true;
            MyProfileFirstname.IsReadOnly = true;
            MyProfileFathersname.IsReadOnly = true;
            MyProfilePhone.IsReadOnly = true;

            MyProfileState.IsReadOnly = true;
            MyProfileCity.IsReadOnly = true;
            MyProfileStreet.IsReadOnly = true;
            MyProfileHouse.IsReadOnly = true;
            MyProfileHousing.IsReadOnly = true;
            MyProfileFlat.IsReadOnly = true;
        }
    }
}
