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

namespace _1223
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Random r = new Random();
            int chislo = r.Next(-900, 555);

            tb_info.Text = chislo.ToString();
            tb_info.FontSize = new Random().Next(0, 99);

            MessageBox.Show($"{chislo} - случайное число ");

        }


        private void cb_eula_agree_Click(object sender, RoutedEventArgs e)
        {
            if (cb_eula_agree.IsChecked.Value)
            {
                MessageBox.Show("ура вы согласились");
                cb_eula_agree.IsEnabled = false;
                //this.Close();
            }
            else
            {
                MessageBox.Show("согласись");
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_login.Text))
            {
                MessageBox.Show("ЛОГИН ПУСТОЙ");
                return;
            }

            if (!string.IsNullOrEmpty(tb_password.Pasword))
            {
                MessageBox.Show("пароль пустой");
                return;
            }

            if (!cb_eula_agree.IsChecked.Value)
            {
                MessageBox.Show("вы не согласились с условием программы");
                return;
            }

            if (login.login.text == 'admin' && tb_password.Password == "123")
            {
                MessageBox.Show("успешно");
            }
            else
            {
                MessageBox.Show("ШАКалЫ");
            }
        }

    }

}
