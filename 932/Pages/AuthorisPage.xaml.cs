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
    /// Логика взаимодействия для AuthorisPage.xaml
    /// </summary>
    public partial class AuthorisPage : Page
    {
        public AuthorisPage()
        {
            InitializeComponent();
        }

        private void BtnAuthoriz_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CapchaPage());
        }

        private void TbRegist_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void TextBlockMouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void TbRegist_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void TextBlockMouseEnter(object sender, MouseEventArgs e)
        {

        }
    }
}
