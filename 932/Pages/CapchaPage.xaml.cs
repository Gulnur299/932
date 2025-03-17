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
    /// Логика взаимодействия для CapchaPage.xaml
    /// </summary>
    public partial class CapchaPage : Page
    {
        Random random = new Random();
        public string capcha = "";
        public CapchaPage()
        {
            InitializeComponent();
        }

        private void GenerateNoise(int volumeNoise)
        {
           for(int i = 0; i < volumeNoise; i++)
            {
                Rectangle r = new Rectangle();
                r.Fill = new SolidColorBrush(Color.FromArgb((byte)random.Next(35,120), (byte)random.Next(256), (byte)random.Next(256), (byte)random.Next(256)));
                r.Width= r.Height=random.Next(3,90);
                cv.Children.Add(r);
                Canvas.SetLeft(r, random.Next(0, 350));
                Canvas.SetTop(r, random.Next(0, 250));
            }
        }
        private void GenerateSymbols(int count)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            for (int i = 0; i < count; i++)
            { 
            string symbol = alphabet.ElementAt(random.Next(0,alphabet.Length)).ToString();
                TextBlock textBlock = new TextBlock();
                textBlock.Text = symbol;
                textBlock.FontSize = random.Next(10, 84);
                textBlock.RenderTransform= new RotateTransform(random.Next(-45,45));
                textBlock.Margin = new Thickness(10, 10, 10, 10);
                textBlock.Foreground = new SolidColorBrush(Color.FromArgb((byte)random.Next(200, 256), (byte)random.Next(200, 256), (byte)random.Next(200, 256), (byte)random.Next(200, 256)));
                SpCapch.Children.Add(textBlock);
                capcha += symbol;
            }
        }
         private void UpdateCapcha()
        {
            SpCapch.Children.Clear();
            cv.Children.Clear();
            GenerateSymbols(5);
            GenerateNoise(10);
        }
        private void UpdCapch_Click_1(object sender, RoutedEventArgs e)
        {
            UpdateCapcha();  
        }

        private void CheckCapch_Click_1(object sender, RoutedEventArgs e)
        {
            if (capcha == tbCapch.Text.Trim().ToUpper())
            {
                MessageBox.Show("УРААААААА Я НЕ БОТИНОК!!!!");
            }
            else
            {
                MessageBox.Show("Ну я ботинок...");
            }
        }
    }
}
