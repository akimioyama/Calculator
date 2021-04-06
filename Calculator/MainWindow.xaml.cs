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
        private string Solution(string mbsrt) // =
        {
            try
            {
                // ∞
                string value = new DataTable().Compute(mbsrt, null).ToString(); // полчуаем строку, которая начинает вычисляться, а посел преобразуем её в новую строку
                                                                                //value = value.Replace(',', '.');

                char ch = ',';

                if (value.IndexOf(ch) != -1)
                {
                    double new_value;                       // проверяем есть ли в ответе запетая, так как лучше работать с точкой
                    new_value = Convert.ToDouble(value);
                    new_value = Math.Round(new_value, 5);
                    value = new_value.ToString();
                    value = value.Replace(',', '.');
                    return value;
                }
                else
                {
                    return value;
                }
            }
            catch
            {
                return "Overflow!";
            }
        }
        private void Button_Click_Solution(object sender, RoutedEventArgs e)  // =
        {
            string new_new_ch = "∞";
            string new_new_new_ch = "-∞";
            string mins = "-";
            string zero1 = "Деление на 0 невозможно";
            string error = "Не число";
            string Overflow = "Overflow!";
            if (TextBlock.Text == zero1 || TextBlock.Text == Overflow || TextBlock.Text == error || TextBlock.Text == new_new_ch || TextBlock.Text == new_new_new_ch || TextBlock.Text == mins)
            {
                AllStr.Text = "";
                TextBlock.Text = "";
            }
            char ch = '=';
            string zero = "/0";
            int len = AllStr.Text.Length;
            if (TextBlock.Text == "") // если пусто, то ничего не делаем
            {
                TextBlock.Text = "";
            }
            else if (AllStr.Text != "" && TextBlock.Text != "" && AllStr.Text[len - 1] != ch) // провераем на всё нужное для вычелсения ответа
            {
                string ss = AllStr.Text + TextBlock.Text;
                if (ss.IndexOf(zero) == -1) // не разрешаем делить на 0
                {
                    AllStr.Text = ss + "=";
                    TextBlock.Text = Solution(ss); // раньше было просто Solution(ss). А он был void и писал TextBlock.Text = value
                }
                else
                {
                    TextBlock.Text = "Деление на 0 невозможно";
                }
            }
            else
            {
                AllStr.Text = "";
            }
        }
        private void Button_Click_On_Multiplication(object sender, RoutedEventArgs e) // *
        {
            string zero = "Деление на 0 невозможно";
            char ch = '.';
            char new_ch = '=';
            int len = TextBlock.Text.Length;
            string secont_str;
            string error = "Не число";

            string new_new_ch = "∞";
            string new_new_new_ch = "-∞";
            string mins = "-";
            string Overflow = "Overflow!";
            if (TextBlock.Text == zero || TextBlock.Text == Overflow || TextBlock.Text == error || TextBlock.Text == new_new_ch || TextBlock.Text == new_new_new_ch || TextBlock.Text == mins)
            {
                AllStr.Text = "";
                TextBlock.Text = "";
            }
            if (TextBlock.Text != "")
            {
                if (ch != TextBlock.Text[len - 1] && AllStr.Text.IndexOf(new_ch) == -1) // проверяем чтобы не было например 8. а былоа 8.6 например
                {
                    secont_str = TextBlock.Text;
                    AllStr.Text += secont_str + "*";
                    TextBlock.Text = "";
                }
                else if (ch != TextBlock.Text[len - 1] && AllStr.Text.IndexOf(new_ch) != -1) // не знаю что я тут на писал и зачем. Но удолять не буду
                {
                    AllStr.Text = TextBlock.Text + "*";
                    TextBlock.Text = "";
                }
            }
            else
            {
                TextBlock.Text = "";
            }
        }
        private void Button_Click_On_Division(object sender, RoutedEventArgs e) // Деление /
        {
            string new_new_ch = "∞";
            string new_new_new_ch = "-∞";
            string mins = "-";
            string zero = "Деление на 0 невозможно";
            string error = "Не число";
            string Overflow = "Overflow!";
            if (TextBlock.Text == zero || TextBlock.Text == Overflow || TextBlock.Text == error || TextBlock.Text == new_new_ch || TextBlock.Text == new_new_new_ch || TextBlock.Text == mins)
            {
                AllStr.Text = "";
                TextBlock.Text = "";
            }
            char ch = '.';
            char new_ch = '=';
            int len = TextBlock.Text.Length;

            string secont_str;
            if (TextBlock.Text != "")
            {
                if (ch != TextBlock.Text[len - 1] && AllStr.Text.IndexOf(new_ch) == -1)
                {
                    secont_str = TextBlock.Text;
                    AllStr.Text += secont_str + "/";
                    TextBlock.Text = "";
                }
                else if (ch != TextBlock.Text[len - 1] && AllStr.Text.IndexOf(new_ch) != -1)
                {
                    AllStr.Text = TextBlock.Text + "/";
                    TextBlock.Text = "";
                }
            }
            else
            {
                TextBlock.Text = "";
            }
        }
        private void Button_Click_On_Plus(object sender, RoutedEventArgs e) //+
        {
            string new_new_ch = "∞";
            string new_new_new_ch = "-∞";
            string mins = "-";
            string zero = "Деление на 0 невозможно";
            string error = "Не число";
            string Overflow = "Overflow!";
            if (TextBlock.Text == zero || TextBlock.Text == Overflow || TextBlock.Text == error || TextBlock.Text == new_new_ch || TextBlock.Text == new_new_new_ch || TextBlock.Text == mins)
            {
                AllStr.Text = "";
                TextBlock.Text = "";
            }
            char ch = '.';
            char new_ch = '=';
            int len = TextBlock.Text.Length;

            //string secont_str;
            if (TextBlock.Text != "")
            {
                if (ch != TextBlock.Text[len - 1] && AllStr.Text.IndexOf(new_ch) == -1)
                {
                    // ТУТ НАПИШИ string ss = Allstr.Text + '+' + TextBlock.Text; А потом их сошюшен и выведи его в AlllStr.Text;
                    AllStr.Text += TextBlock.Text + "+";
                    TextBlock.Text = "";
                }
                else if (ch != TextBlock.Text[len - 1] && AllStr.Text.IndexOf(new_ch) != -1)
                {
                    AllStr.Text = TextBlock.Text + "+";
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
            string new_new_ch = "∞";
            string new_new_new_ch = "-∞";
            string mins = "-";
            string zero = "Деление на 0 невозможно";
            string error = "Не число";
            string Overflow = "Overflow!";
            if (TextBlock.Text == zero || TextBlock.Text == Overflow || TextBlock.Text == error || TextBlock.Text == new_new_ch || TextBlock.Text == new_new_new_ch || TextBlock.Text == mins)
            {
                AllStr.Text = "";
                TextBlock.Text = "";
            }
            char ch = '.';
            char new_ch = '=';
            int len = TextBlock.Text.Length;
            string secont_str;
            if (TextBlock.Text != "")
            {
                if (ch != TextBlock.Text[len - 1] && AllStr.Text.IndexOf(new_ch) == -1)
                {
                    secont_str = TextBlock.Text;
                    AllStr.Text += secont_str + "-";
                    TextBlock.Text = "";
                }
                else if (ch != TextBlock.Text[len - 1] && AllStr.Text.IndexOf(new_ch) != -1)
                {
                    AllStr.Text = TextBlock.Text + "-";
                    TextBlock.Text = "";
                }
            }
            else
            {
                TextBlock.Text = "";
            }
        }
        private void Button_Click_On_C(object sender, RoutedEventArgs e) // c  Просто всё удаляем
        {
            TextBlock.Text = "";
            AllStr.Text = "";
        }
        private void Button_Click_On_CE(object sender, RoutedEventArgs e) // CE – сокращение от англ. «Clean Entry» — «очистить запись»
        {
            TextBlock.Text = "";
        }
        private void Button_Click_On_Comma(object sender, RoutedEventArgs e) // ,
        {
            string new_new_ch = "∞";
            string new_new_new_ch = "-∞";
            string mins = "-";
            string zero = "Деление на 0 невозможно";
            string error = "Не число";
            string Overflow = "Overflow!";
            if (TextBlock.Text == zero || TextBlock.Text == Overflow || TextBlock.Text == error || TextBlock.Text == new_new_ch || TextBlock.Text == new_new_new_ch || TextBlock.Text == mins)
            {
                AllStr.Text = "";
                TextBlock.Text = "";
            }

            char ch = '.';
            int len = TextBlock.Text.Length;
            int count = 0;
            for (int i = 0; i < TextBlock.Text.Length; i++) // ищем сколько . в тексте
            {
                if (TextBlock.Text[i] == ch)
                {
                    count++;
                }
            }

            if (TextBlock.Text != "")
            {
                if (TextBlock.Text[len - 1] != ch && count == 0) // точку можно добавть, если её нет ещё, а дальше вообще её ставить нельзя
                {
                    TextBlock.Text = TextBlock.Text + ch;
                }
                else
                {
                    TextBlock.Text = TextBlock.Text;
                }
            }
            else
            {
                TextBlock.Text = "";
            }
        }
        private void Button_Click_On_DEL(object sender, RoutedEventArgs e) // DEL
        {
            string zero = "Деление на 0 невозможно";
            string error = "Не число";
            string Overflow = "Overflow!";
            if (TextBlock.Text == zero || TextBlock.Text == Overflow || TextBlock.Text == error)
            {
                AllStr.Text = "";
                TextBlock.Text = "";
            }
            string str = TextBlock.Text;
            int len = str.Length;
            string new_str;
            if (TextBlock.Text.IndexOf('E') == -1)
            {
                if (len != 0)
                {
                    new_str = str.Substring(0, len - 1); // уменьщаем длину на едениец прикаждом нажати DEL
                }
                else
                {
                    new_str = "";
                }
                TextBlock.Text = new_str;
            }
            else
            {
                TextBlock.Text = TextBlock.Text;
            }
        }
        private void Button_Click_On_Plus_Minus(object sender, RoutedEventArgs e) // +/-
        {
            string zero = "Деление на 0 невозможно";
            string error = "Не число";
            string Overflow = "Overflow!";
            if (TextBlock.Text == zero || TextBlock.Text == Overflow || TextBlock.Text == error)
            {
                AllStr.Text = "";
                TextBlock.Text = "";
            }
            if (TextBlock.Text != "")
            {
                try
                {
                    string asd = TextBlock.Text;
                    asd = asd.Replace('.', ','); // с . не работало 
                    double qwe = Double.Parse(asd);
                    qwe = qwe * -1;
                    string zxc = qwe.ToString();
                    zxc = zxc.Replace(',', '.');
                    TextBlock.Text = zxc;
                }
                catch
                {
                    TextBlock.Text = "";
                }
            }
            else
            {
                TextBlock.Text = TextBlock.Text;
            }
        }
        private double Pow(double x) // возводим в x^2
        {
            return Math.Pow(x, 2);
        }
        private void Button_Click_On_Power(object sender, RoutedEventArgs e) // x^2
        {
            string new_new_ch = "∞";
            string new_new_new_ch = "-∞";
            string zero = "Деление на 0 невозможно";
            string error = "Не число";
            string Overflow = "Overflow!";
            string mins = "-";
            if (TextBlock.Text == zero || TextBlock.Text == Overflow || TextBlock.Text == error || TextBlock.Text == new_new_ch || TextBlock.Text == new_new_new_ch || TextBlock.Text == mins)
            {
                AllStr.Text = "";
                TextBlock.Text = "";
            }
            try
            {
            if (TextBlock.Text != "")
            {
                string asd = TextBlock.Text;
                asd = asd.Replace('.', ',');
                double for_pow = Double.Parse(asd);
                double for_new_pow = Pow(for_pow);
                string zxc = for_new_pow.ToString();
                zxc = zxc.Replace(',', '.');

                if (zxc != new_new_ch)
                {
                    TextBlock.Text = zxc;
                    AllStr.Text = "";
                }
                else
                {
                    AllStr.Text = "";
                    TextBlock.Text = "Overflow!";
                }
            }
            }
            catch
            {
                TextBlock.Text = error;
            }
            
        }
        private double Sqrt(double x)
        {
            return Math.Sqrt(x);
        }
        private void Button_Click_On_Sqrt(object sender, RoutedEventArgs e) // sqrt
        {
            string new_new_ch = "∞";
            string new_new_new_ch = "-∞";
            string zero = "Деление на 0 невозможно";
            string error = "Не число";
            string Overflow = "Overflow!";
            string mins = "-";
            if (TextBlock.Text == zero || TextBlock.Text == Overflow || TextBlock.Text == error || TextBlock.Text == new_new_ch || TextBlock.Text == new_new_new_ch || TextBlock.Text == mins)
            {
                AllStr.Text = "";
                TextBlock.Text = "";
            }
            if (TextBlock.Text != "")
            {
                if (TextBlock.Text[0] != '-') // проверка на извелчение отрицательного числа из под корня
                {
                    try
                    {
                        string asd = TextBlock.Text;
                        asd = asd.Replace('.', ',');
                        double for_Sqrt = Double.Parse(asd);
                        double for_new_Sqrt = Sqrt(for_Sqrt);
                        string zxc = for_new_Sqrt.ToString();
                        zxc = zxc.Replace(',', '.');
                        TextBlock.Text = zxc;
                        AllStr.Text = "";
                    }
                    catch
                    {
                        AllStr.Text = "";
                        TextBlock.Text = ":)";
                    }
                    
                }
                else
                {
                    TextBlock.Text = error;
                }
            }

        }
        private void Button_Click_On_1_Obr(object sender, RoutedEventArgs e) // 1/x
        {
            string zero = "Деление на 0 невозможно";
            string error = "Не число";
            if (TextBlock.Text != "")
            {
                string Overflow = "Overflow!";
                string mins = "-";
                if (TextBlock.Text == zero || TextBlock.Text == Overflow || TextBlock.Text == error || TextBlock.Text == mins)
                {
                    AllStr.Text = "";
                    TextBlock.Text = "";
                }
                else if (TextBlock.Text == "0" || TextBlock.Text == "0.")
                {
                    TextBlock.Text = zero;
                }
                else
                {
                    try
                    {
                        string asd = TextBlock.Text;
                        asd = asd.Replace('.', ',');
                        double uuu = Double.Parse(asd);
                        uuu = 1 / uuu;
                        string zxc = uuu.ToString();
                        zxc = zxc.Replace(',', '.');
                        TextBlock.Text = zxc;
                        AllStr.Text = "";
                    }
                    catch
                    {
                        TextBlock.Text = error;
                    }
                }
            }
        }
        private void Button_Click_On_Percent(object sender, RoutedEventArgs e) //  %
        {
            string zero = "Деление на 0 невозможно";
            string error = "Не число";
            //char[] qwe = {'+', '-', '*', '/' };
            string Overflow = "Overflow!";
            string mins = "-";
            string new_new_ch = "∞";
            string new_new_new_ch = "-∞";
            if (TextBlock.Text == zero || TextBlock.Text == Overflow || TextBlock.Text == error || TextBlock.Text == new_new_ch || TextBlock.Text == new_new_new_ch || TextBlock.Text == mins)
            {
                AllStr.Text = "";
                TextBlock.Text = "";
            }
            if (AllStr.Text != "")
            {
                if (AllStr.Text[AllStr.Text.Length - 1] == '+' || AllStr.Text[AllStr.Text.Length - 1] == '-' || AllStr.Text[AllStr.Text.Length - 1] == '*' || AllStr.Text[AllStr.Text.Length - 1] == '/')
                {
                    string right_new = TextBlock.Text; // число например 5%
                    right_new = right_new.Replace('.', ','); //если число например 5.4%
                    double uuu = Double.Parse(right_new); // число но в дабле

                    int qqq = AllStr.Text.Length; // число от которого считаются проценты
                    string old_new = AllStr.Text.Substring(0, qqq - 1); // всё кроме последнего сивола
                    old_new = old_new.Replace('.', ',');
                    double www = Double.Parse(old_new); // число но в дабле

                    double one_prosent = www / 100;
                    double result = uuu * one_prosent;

                    string new_result = result.ToString();
                    new_result = new_result.Replace(',', '.');
                    TextBlock.Text = new_result;
                }
            }
            else
            {
                TextBlock.Text = "";
                AllStr.Text = "";
            }

        }
        private string dlina(string x)
        {
            int max = 15;
            if (x.Length > max)
            {
                x = x.Substring(0, max);
                return x;
            }
            else
            {
                return x;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e) //параметры при обратоке нажатия
        {
            string str = (string)((Button) e.OriginalSource).Content; // в строку присваеваем значение нашей копки (е - обект класса RoutedEventArgs, потом преобразуем его
                                                                      // к классу кнопки. OriginalSource - берём сам этот обект и Content - возращаем его содержимое)
            string zero = "Деление на 0 невозможно";
            string error = "Не число";
            string new_new_ch = "∞";
            string new_new_new_ch = "-∞";
            string mins = "-";
            string Overflow = "Overflow!";
            switch (str) 
            {

                case "1":
                    if (TextBlock.Text == zero || TextBlock.Text == Overflow || TextBlock.Text == error || TextBlock.Text == new_new_ch || TextBlock.Text == new_new_new_ch || TextBlock.Text == mins)
                    {
                        AllStr.Text = "";
                        TextBlock.Text = "";
                    }
                    if (AllStr.Text != "") // ДОПИСАТЬ ЧТО TextBlock.Text != ""; А потом другой if где AllStr.Text == "", но TextBlock.Text != ""
                    {
                        if (AllStr.Text[AllStr.Text.Length - 1] == '=' && TextBlock.Text != "")
                        {
                            AllStr.Text = "";
                            TextBlock.Text = "";
                            TextBlock.Text += str;
                            break;
                        }
                    }

                    if (TextBlock.Text.Length == 0)
                    {
                        TextBlock.Text += str;
                        break;
                    }
                    else if (TextBlock.Text[0] == '0' && TextBlock.Text.Length < 2)
                    {
                        TextBlock.Text = TextBlock.Text;
                        break;
                    }
                    else if (TextBlock.Text.Length >= 16 && TextBlock.Text.IndexOf('E') == -1)
                    {
                        TextBlock.Text = TextBlock.Text.Substring(0, 16);
                        break;
                    }
                    else if (TextBlock.Text.Length >= 16 && TextBlock.Text.IndexOf('E') != -1)
                    {
                        TextBlock.Text = TextBlock.Text;
                        break;
                    }
                    else
                    {
                        TextBlock.Text += str;
                        break;
                    }
                case "2":
                    if (TextBlock.Text == zero || TextBlock.Text == Overflow || TextBlock.Text == error || TextBlock.Text == new_new_ch || TextBlock.Text == new_new_new_ch || TextBlock.Text == mins)
                    {
                        AllStr.Text = "";
                        TextBlock.Text = "";
                    }
                    if (AllStr.Text != "")
                    {
                        if (AllStr.Text[AllStr.Text.Length - 1] == '=' && TextBlock.Text != "")
                        {
                            AllStr.Text = "";
                            TextBlock.Text = "";
                            TextBlock.Text += str;
                            break;
                        }
                    }
                    if (TextBlock.Text.Length == 0)
                    {
                        TextBlock.Text += str;
                        break;
                    }
                    else if (TextBlock.Text[0] == '0' && TextBlock.Text.Length < 2)
                    {
                        TextBlock.Text = TextBlock.Text;
                        break;
                    }
                    else if (TextBlock.Text.Length >= 16 && TextBlock.Text.IndexOf('E') == -1)
                    {
                        TextBlock.Text = TextBlock.Text.Substring(0, 16);
                        break;
                    }
                    else if (TextBlock.Text.Length >= 16 && TextBlock.Text.IndexOf('E') != -1)
                    {
                        TextBlock.Text = TextBlock.Text;
                        break;
                    }
                    else
                    {
                        TextBlock.Text += str;
                        break;
                    }
                case "3":
                    if (TextBlock.Text == zero || TextBlock.Text == Overflow || TextBlock.Text == error || TextBlock.Text == new_new_ch || TextBlock.Text == new_new_new_ch || TextBlock.Text == mins)
                    {
                        AllStr.Text = "";
                        TextBlock.Text = "";
                    }
                    if (AllStr.Text != "")
                    {
                        if (AllStr.Text[AllStr.Text.Length - 1] == '=' && TextBlock.Text != "")
                        {
                            AllStr.Text = "";
                            TextBlock.Text = "";
                            TextBlock.Text += str;
                            break;
                        }
                    }
                    if (TextBlock.Text.Length == 0)
                    {
                        TextBlock.Text += str;
                        break;
                    }
                    else if (TextBlock.Text[0] == '0' && TextBlock.Text.Length < 2)
                    {
                        TextBlock.Text = TextBlock.Text;
                        break;
                    }
                    else if (TextBlock.Text.Length >= 16 && TextBlock.Text.IndexOf('E') == -1)
                    {
                        TextBlock.Text = TextBlock.Text.Substring(0, 16);
                        break;
                    }
                    else if (TextBlock.Text.Length >= 16 && TextBlock.Text.IndexOf('E') != -1)
                    {
                        TextBlock.Text = TextBlock.Text;
                        break;
                    }
                    else
                    {
                        TextBlock.Text += str;
                        break;
                    }
                case "4":
                    if (TextBlock.Text == zero || TextBlock.Text == Overflow || TextBlock.Text == error || TextBlock.Text == new_new_ch || TextBlock.Text == new_new_new_ch || TextBlock.Text == mins)
                    {
                        AllStr.Text = "";
                        TextBlock.Text = "";
                    }
                    if (AllStr.Text != "")
                    {
                        if (AllStr.Text[AllStr.Text.Length - 1] == '=' && TextBlock.Text != "")
                        {
                            AllStr.Text = "";
                            TextBlock.Text = "";
                            TextBlock.Text += str;
                            break;
                        }
                    }
                    if (TextBlock.Text.Length == 0)
                    {
                        TextBlock.Text += str;
                        break;
                    }
                    else if (TextBlock.Text[0] == '0' && TextBlock.Text.Length < 2)
                    {
                        TextBlock.Text = TextBlock.Text;
                        break;
                    }
                    else if (TextBlock.Text.Length >= 16 && TextBlock.Text.IndexOf('E') == -1)
                    {
                        TextBlock.Text = TextBlock.Text.Substring(0, 16);
                        break;
                    }
                    else if (TextBlock.Text.Length >= 16 && TextBlock.Text.IndexOf('E') != -1)
                    {
                        TextBlock.Text = TextBlock.Text;
                        break;
                    }
                    else
                    {
                        TextBlock.Text += str;
                        break;
                    }
                case "5":
                    if (TextBlock.Text == zero || TextBlock.Text == Overflow || TextBlock.Text == error || TextBlock.Text == new_new_ch || TextBlock.Text == new_new_new_ch || TextBlock.Text == mins)
                    {
                        AllStr.Text = "";
                        TextBlock.Text = "";
                    }
                    if (AllStr.Text != "")
                    {
                        if (AllStr.Text[AllStr.Text.Length - 1] == '=' && TextBlock.Text != "")
                        {
                            AllStr.Text = "";
                            TextBlock.Text = "";
                            TextBlock.Text += str;
                            break;
                        }
                    }
                    if (TextBlock.Text.Length == 0)
                    {
                        TextBlock.Text += str;
                        break;
                    }
                    else if (TextBlock.Text[0] == '0' && TextBlock.Text.Length < 2)
                    {
                        TextBlock.Text = TextBlock.Text;
                        break;
                    }
                    else if (TextBlock.Text.Length >= 16 && TextBlock.Text.IndexOf('E') == -1)
                    {
                        TextBlock.Text = TextBlock.Text.Substring(0, 16);
                        break;
                    }
                    else if (TextBlock.Text.Length >= 16 && TextBlock.Text.IndexOf('E') != -1)
                    {
                        TextBlock.Text = TextBlock.Text;
                        break;
                    }
                    else
                    {
                        TextBlock.Text += str;
                        break;
                    }
                case "6":
                    if (TextBlock.Text == zero || TextBlock.Text == Overflow || TextBlock.Text == error || TextBlock.Text == new_new_ch || TextBlock.Text == new_new_new_ch || TextBlock.Text == mins)
                    {
                        AllStr.Text = "";
                        TextBlock.Text = "";
                    }
                    if (AllStr.Text != "")
                    {
                        if (AllStr.Text[AllStr.Text.Length - 1] == '=' && TextBlock.Text != "")
                        {
                            AllStr.Text = "";
                            TextBlock.Text = "";
                            TextBlock.Text += str;
                            break;
                        }
                    }
                    if (TextBlock.Text.Length == 0)
                    {
                        TextBlock.Text += str;
                        break;
                    }
                    else if (TextBlock.Text[0] == '0' && TextBlock.Text.Length < 2)
                    {
                        TextBlock.Text = TextBlock.Text;
                        break;
                    }
                    else if (TextBlock.Text.Length >= 16 && TextBlock.Text.IndexOf('E') == -1)
                    {
                        TextBlock.Text = TextBlock.Text.Substring(0, 16);
                        break;
                    }
                    else if (TextBlock.Text.Length >= 16 && TextBlock.Text.IndexOf('E') != -1)
                    {
                        TextBlock.Text = TextBlock.Text;
                        break;
                    }
                    else
                    {
                        TextBlock.Text += str;
                        break;
                    }
                case "7":
                    if (TextBlock.Text == zero || TextBlock.Text == Overflow || TextBlock.Text == error || TextBlock.Text == new_new_ch || TextBlock.Text == new_new_new_ch || TextBlock.Text == mins)
                    {
                        AllStr.Text = "";
                        TextBlock.Text = "";
                    }
                    if (AllStr.Text != "")
                    {
                        if (AllStr.Text[AllStr.Text.Length - 1] == '=' && TextBlock.Text != "")
                        {
                            AllStr.Text = "";
                            TextBlock.Text = "";
                            TextBlock.Text += str;
                            break;
                        }
                    }
                    if (TextBlock.Text.Length == 0)
                    {
                        TextBlock.Text += str;
                        break;
                    }
                    else if (TextBlock.Text[0] == '0' && TextBlock.Text.Length < 2)
                    {
                        TextBlock.Text = TextBlock.Text;
                        break;
                    }
                    else if (TextBlock.Text.Length >= 16 && TextBlock.Text.IndexOf('E') == -1)
                    {
                        TextBlock.Text = TextBlock.Text.Substring(0, 16);
                        break;
                    }
                    else if (TextBlock.Text.Length >= 16 && TextBlock.Text.IndexOf('E') != -1)
                    {
                        TextBlock.Text = TextBlock.Text;
                        break;
                    }
                    else
                    {
                        TextBlock.Text += str;
                        break;
                    }
                case "8":
                    if (TextBlock.Text == zero || TextBlock.Text == Overflow || TextBlock.Text == error || TextBlock.Text == new_new_ch || TextBlock.Text == new_new_new_ch || TextBlock.Text == mins)
                    {
                        AllStr.Text = "";
                        TextBlock.Text = "";
                    }
                    if (AllStr.Text != "")
                    {
                        if (AllStr.Text[AllStr.Text.Length - 1] == '=' && TextBlock.Text != "")
                        {
                            AllStr.Text = "";
                            TextBlock.Text = "";
                            TextBlock.Text += str;
                            break;
                        }
                    }
                    if (TextBlock.Text.Length == 0)
                    {
                        TextBlock.Text += str;
                        break;
                    }
                    else if (TextBlock.Text[0] == '0' && TextBlock.Text.Length < 2)
                    {
                        TextBlock.Text = TextBlock.Text;
                        break;
                    }
                    else if (TextBlock.Text.Length >= 16 && TextBlock.Text.IndexOf('E') == -1)
                    {
                        TextBlock.Text = TextBlock.Text.Substring(0, 16);
                        break;
                    }
                    else if (TextBlock.Text.Length >= 16 && TextBlock.Text.IndexOf('E') != -1)
                    {
                        TextBlock.Text = TextBlock.Text;
                        break;
                    }
                    else
                    {
                        TextBlock.Text += str;
                        break;
                    }
                case "9":
                    if (TextBlock.Text == zero || TextBlock.Text == Overflow || TextBlock.Text == error || TextBlock.Text == new_new_ch || TextBlock.Text == new_new_new_ch || TextBlock.Text == mins)
                    {
                        AllStr.Text = "";
                        TextBlock.Text = "";
                    }
                    if (AllStr.Text != "")
                    {
                        if (AllStr.Text[AllStr.Text.Length - 1] == '=' && TextBlock.Text != "")
                        {
                            AllStr.Text = "";
                            TextBlock.Text = "";
                            TextBlock.Text += str;
                            break;
                        }
                    }
                    if (TextBlock.Text.Length == 0)
                    {
                        TextBlock.Text += str;
                        break;
                    }
                    else if (TextBlock.Text[0] == '0' && TextBlock.Text.Length < 2)
                    {
                        TextBlock.Text = TextBlock.Text;
                        break;
                    }
                    else if (TextBlock.Text.Length >= 16 && TextBlock.Text.IndexOf('E') == -1)
                    {
                        TextBlock.Text = TextBlock.Text.Substring(0, 16);
                        break;
                    }
                    else if (TextBlock.Text.Length >= 16 && TextBlock.Text.IndexOf('E') != -1)
                    {
                        TextBlock.Text = TextBlock.Text;
                        break;
                    }
                    else
                    {
                        TextBlock.Text += str;
                        break;
                    }
                case "0":
                    if (TextBlock.Text == zero || TextBlock.Text == Overflow || TextBlock.Text == error || TextBlock.Text == new_new_ch || TextBlock.Text == new_new_new_ch || TextBlock.Text == mins)
                    {
                        AllStr.Text = "";
                        TextBlock.Text = "";
                    }
                    if (AllStr.Text != "")
                    {
                        if (AllStr.Text[AllStr.Text.Length - 1] == '=' && TextBlock.Text != "")
                        {
                            AllStr.Text = "";
                            TextBlock.Text = "";
                            TextBlock.Text += str;
                            break;
                        }
                    }
                    if (TextBlock.Text.Length == 0)
                    {
                        TextBlock.Text += str;
                        break;
                    }
                    else if (TextBlock.Text[0] == '0' && TextBlock.Text.Length < 2)
                    {
                        TextBlock.Text = TextBlock.Text;
                        break;
                    }
                    else if (TextBlock.Text.Length >= 16 && TextBlock.Text.IndexOf('E') == -1)
                    {
                        TextBlock.Text = TextBlock.Text.Substring(0, 16);
                        break;
                    }
                    else if (TextBlock.Text.Length >= 16 && TextBlock.Text.IndexOf('E') != -1)
                    {
                        TextBlock.Text = TextBlock.Text;
                        break;
                    }
                    else
                    {
                        TextBlock.Text += str;
                        break;
                    }
            }

        }

        //private void label1_TextChanged(object sender, EventArgs e)
        // {
        //   if (label1.Text.Length > 6)
        //      label1.Text = label1.Text.Substring(0, 6);
        // }
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
