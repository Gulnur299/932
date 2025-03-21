using _932.Functions;
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

namespace _932.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorisPage());
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //string fio = tbLastName.Text+ " "+ tbName.Text+" "+tbSurName.Text;
            //string fio=tbFullName.Text.Trim();

            string surname = tbLastName.Text.Trim();
            string name = tbLastName.Text.Trim();
            string lastname = tbLastName.Text.Trim();
            string phone=tbPhone.Text.Trim();
            string password= tbPass.Text.Trim();
            if (lastname !=null && name != null && password !=null)
            {
                Registration.RegistrationSotr(lastname, name, surname, phone, password);
                System.Windows.MessageBox.Show("Регистрация прошла успешно");
                NavigationService.Navigate(new AuthorisPage());
            }
            else
            {
                MessageBox.Show("Фамилия или Имя или пароль пусты");
            }
        }
    }
}
