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



