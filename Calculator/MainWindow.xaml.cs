using System;
using System.Collections.Generic;
using System.Data;
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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void Solution(string mbsrt) // =
        {
            string value = new DataTable().Compute(mbsrt, null).ToString();
            TextBlock.Text = value;
        }
        private void Button_Click_On_Plus(object sender, RoutedEventArgs e) //+
        {
            char ch = '.';
            int len = TextBlock.Text.Length;

            string secont_str;
            if (TextBlock.Text != "")
            {
                if (ch != TextBlock.Text[len - 1])
                {
                    secont_str = TextBlock.Text;
                    AllStr.Text += secont_str + "+";
                    TextBlock.Text = "";
                }
            }
            else
            {
                TextBlock.Text = "";
            }
        }
        private void Button_Click_On_Minus(object sender, RoutedEventArgs e) // -
        {
            char ch = '.';
            int len = TextBlock.Text.Length;
            string secont_str;
            if (TextBlock.Text != "")
            {
                if (ch != TextBlock.Text[len - 1])
                {
                    secont_str = TextBlock.Text;
                    AllStr.Text += secont_str + "-";
                    TextBlock.Text = "";
                }
            }
            else
            {
                TextBlock.Text = "";
            }
        }
        private void Button_Click_On_C(object sender, RoutedEventArgs e) // c
        {
            TextBlock.Text = "";
            AllStr.Text = "";
        }
        private void Button_Click_On_Comma(object sender, RoutedEventArgs e) // ,
        {
            char ch = '.';
            int len = TextBlock.Text.Length;
            int count = 0;
            for (int i = 0; i < TextBlock.Text.Length; i++)
            {
                if (TextBlock.Text[i] == ch)
                {
                    count++;
                }
            }

            if (TextBlock.Text[len - 1] != ch && count == 0)
            {
                TextBlock.Text = TextBlock.Text + ch;
            }
            else
            {
                TextBlock.Text = TextBlock.Text;
            }
            
        }
        private void Button_Click_On_DEL(object sender, RoutedEventArgs e) // DEL
        {
            string str = TextBlock.Text;
            int len = str.Length;
            string new_str;
            if (len != 0)
            {
                new_str = str.Substring(0, len - 1);
            }
            else
            {
                new_str = "";
            }
            TextBlock.Text = new_str;
        }
        private void Button_Click(object sender, RoutedEventArgs e) //параметры при обратоке нажатия
        {
            string str = (string)((Button) e.OriginalSource).Content; // в строку присваеваем значение нашей копки (е - обект класса RoutedEventArgs, потом преобразуем его
            // к классу кнопки. OriginalSource - берём сам этот обект и Content - возращаем его содержимое)

            switch (str) 
            {
                case "1":
                    TextBlock.Text += str;
                    break;
                case "2":
                    TextBlock.Text += str;
                    break;
                case "3":
                    TextBlock.Text += str;
                    break;
                case "4":
                    TextBlock.Text += str;
                    break;
                case "5":
                    TextBlock.Text += str;
                    break;
                case "6":
                    TextBlock.Text += str;
                    break;
                case "7":
                    TextBlock.Text += str;
                    break;
                case "8":
                    TextBlock.Text += str;
                    break;
                case "9":
                    TextBlock.Text += str;
                    break;
                case "0":
                    TextBlock.Text += str;
                    break;
                case "=":
                    string ss = AllStr.Text + TextBlock.Text;
                    AllStr.Text = ss + "=";
                    Solution(ss);
                    break;
            }

        }


        public MainWindow()
        {
            InitializeComponent();

            foreach(UIElement elements in MainRoot.Children)  //Обраточик событий только для кнопок с цифрами !
            {
                if (elements is Button)
                {
                    //преобразование elements к классу Button и вызов функции
                    ((Button) elements).Click += Button_Click;
                }
            }
        }
    }
}
