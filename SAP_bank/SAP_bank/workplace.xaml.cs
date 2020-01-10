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
    /// Логика взаимодействия для workplace.xaml
    /// </summary>
    public partial class workplace : Window
    {
        public workplace()
        {
            InitializeComponent();
        }

        private void ButtonPopUpLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;            
        }
        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;         
                    
        }


        private void ConverterButton_Click(object sender, RoutedEventArgs e)
        {
            HeaderWork.Text = "Конвертер валют";
            ucDeposit.Visibility = Visibility.Hidden;
            ucTransfer.Visibility = Visibility.Hidden;
            ucChangePassword.Visibility = Visibility.Hidden;
            ucMyHistory.Visibility = Visibility.Hidden;
            ucMyBalance.Visibility = Visibility.Hidden;
            ucMyProfile.Visibility = Visibility.Hidden;
            ucConverter.Visibility = Visibility.Visible;
        }

        private void DepositButton_Click(object sender, RoutedEventArgs e)
        {
            HeaderWork.Text = "Депозит";
            ucConverter.Visibility = Visibility.Hidden;
            ucTransfer.Visibility = Visibility.Hidden;
            ucMyHistory.Visibility = Visibility.Hidden;
            ucMyBalance.Visibility = Visibility.Hidden;
            ucChangePassword.Visibility = Visibility.Hidden;
            ucMyProfile.Visibility = Visibility.Hidden;
            ucDeposit.Visibility = Visibility.Visible;
        }

        private void TransferButton_Click(object sender, RoutedEventArgs e)
        {
            HeaderWork.Text = "Перевод средств";
            ucConverter.Visibility = Visibility.Hidden;
            ucDeposit.Visibility = Visibility.Hidden;
            ucMyHistory.Visibility = Visibility.Hidden;
            ucChangePassword.Visibility = Visibility.Hidden;
            ucMyBalance.Visibility = Visibility.Hidden;
            ucMyProfile.Visibility = Visibility.Hidden;
            ucTransfer.Visibility = Visibility.Visible;
        }

        private void MyHistoryButton_Click(object sender, RoutedEventArgs e)
        {
            HeaderWork.Text = "Моя история";
            ucConverter.Visibility = Visibility.Hidden;
            ucDeposit.Visibility = Visibility.Hidden;
            ucTransfer.Visibility = Visibility.Hidden;
            ucChangePassword.Visibility = Visibility.Hidden;
            ucMyBalance.Visibility = Visibility.Hidden;
            ucMyProfile.Visibility = Visibility.Hidden;
            ucMyHistory.Visibility = Visibility.Visible;
        }

        private void MyBalanceButton_Click(object sender, RoutedEventArgs e)
        {
            HeaderWork.Text = "Мой баланс";
            ucConverter.Visibility = Visibility.Hidden;
            ucDeposit.Visibility = Visibility.Hidden;
            ucTransfer.Visibility = Visibility.Hidden;
            ucMyHistory.Visibility = Visibility.Hidden;
            ucChangePassword.Visibility = Visibility.Hidden;
            ucMyProfile.Visibility = Visibility.Hidden;
            ucMyBalance.Visibility = Visibility.Visible;
        }

        private void MyProfileButton_Click(object sender, RoutedEventArgs e)
        {
            HeaderWork.Text = "Мой профиль";
            ucConverter.Visibility = Visibility.Hidden;
            ucDeposit.Visibility = Visibility.Hidden;
            ucTransfer.Visibility = Visibility.Hidden;
            ucChangePassword.Visibility = Visibility.Hidden;
            ucMyHistory.Visibility = Visibility.Hidden;
            ucMyBalance.Visibility = Visibility.Hidden;
            ucMyProfile.Visibility = Visibility.Visible;
        }

        private void MyProfileButton_ChangePassword_Click(object sender, RoutedEventArgs e)
        {
            HeaderWork.Text = "Изменение пароля";
            ucConverter.Visibility = Visibility.Hidden;
            ucDeposit.Visibility = Visibility.Hidden;
            ucTransfer.Visibility = Visibility.Hidden;
            ucMyHistory.Visibility = Visibility.Hidden;           
            ucMyProfile.Visibility = Visibility.Hidden;
            ucMyBalance.Visibility = Visibility.Hidden;
            ucChangePassword.Visibility = Visibility.Visible;
        }
    }
}
