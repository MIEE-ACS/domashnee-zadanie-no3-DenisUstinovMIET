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

namespace DZ3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int Sum = 0;
            string text = tbIn.Text;
            int N = text.Length;
            string Text = text.ToLower();
            /*
            char[] text = new char[N];
            for (int i=0; i<N; i++) 
            {
                text[i] = Text[i];
            }
            */

            if (RdBt1.IsChecked == true) 
            {
                for (int i = 0; i < N; i++)
                {
                    if (Text[i] == 'у' || Text[i] == 'е'
                        || Text[i] == 'ы' || Text[i] == 'а'
                        || Text[i] == 'ы' || Text[i] == 'а'
                        || Text[i] == 'о' || Text[i] == 'э'
                        || Text[i] == 'я' || Text[i] == 'и'
                        || Text[i] == 'ю' || Text[i] == 'ё')
                        Sum++;
                }
            }
            else if (RdBt2.IsChecked == true) 
            {
                for (int i = 0; i < N; i++)
                {
                    if (Text[i] == 'й' || Text[i] == 'ц'
                        || Text[i] == 'к' || Text[i] == 'н'
                        || Text[i] == 'ш' || Text[i] == 'г'
                        || Text[i] == 'з' || Text[i] == 'щ'
                        || Text[i] == 'ф' || Text[i] == 'х'
                        || Text[i] == 'в' || Text[i] == 'п'
                        || Text[i] == 'р' || Text[i] == 'д'
                        || Text[i] == 'ж' || Text[i] == 'л'
                        || Text[i] == 'ч' || Text[i] == 'с'
                        || Text[i] == 'м' || Text[i] == 'т'
                        || Text[i] == 'б')
                        Sum++;
                }
            }
            else
            {
                MessageBox.Show("Выберите один из параметров");
            }

            tbOut.Text = String.Format("{0}", Sum);
        }

        private void tbIn_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbOut.Text = String.Format("{0}", "");
        }

        private void RdBt1_Checked(object sender, RoutedEventArgs e)
        {
            tbOut.Text = String.Format("{0}", "");
        }

        private void RdBt2_Checked(object sender, RoutedEventArgs e)
        {
            tbOut.Text = String.Format("{0}", "");
        }
    }
}
/*private void Button_Click(object sender, RoutedEventArgs e)
{
byte red = 255; byte green = 255; byte blue = 255;
if (ChBx1.IsChecked == true && ChBx2.IsChecked == false)
{
int list = CmB.SelectedIndex; //Берём значение из списка
switch (list)
{
case 0: // красный
red = 255; green = 0; blue = 0;
break;
case 1: // зелёный
red = 0; green = 255; blue = 0;
break;
case 2: // синий
red = 0; green = 0; blue = 255;
break;
case 3: // жёлтый
red = 255; green = 255; blue = 0;
break;
case 4: // оранжевый
red = 255; green = 123; blue = 0;
break;
case 5: // фиолетовый
red = 200; green = 0; blue = 255;
break;
case 6: // чёрный
red = 0; green = 0; blue = 0;
break;
case 7: // белый
red = 255; green = 255; blue = 255;
break;
case 8: // голубой
red = 0; green = 255; blue = 255;
break;
case 9: // розовый
red = 255; green = 120; blue = 120;
break;
}
Background = new SolidColorBrush(Color.FromArgb(255, red, green, blue));

}
else if (ChBx1.IsChecked == false && ChBx2.IsChecked == true)
{
bool Key = true;
while (!byte.TryParse((TBR.Text), out red))
{
MessageBox.Show("Напишите в строке R число от 0 до 255");
Key = false;
break;
}
while (!byte.TryParse((TBG.Text), out red))
{
MessageBox.Show("Напишите в строке G число от 0 до 255");
Key = false;
break;
}
while (!byte.TryParse((TBB.Text), out red))
{
MessageBox.Show("Напишите в строке B число от 0 до 255");
Key = false;
break;
}
if (Key == true)
Background = new SolidColorBrush(Color.FromArgb(255, red, green, blue));
}
else
{
MessageBox.Show("Выберите одину из граф");
}

}*/





