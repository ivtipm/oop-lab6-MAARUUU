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

namespace IdealWeight
{
    public partial class MainWindow : Window
    {
        DataUser datauser = new DataUser();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string s = Convert.ToString(Math.Round(datauser.Ideal_Weight(),2));
            end.Content += "   " + s;
            string q = Convert.ToString(Math.Round(datauser.IMT(), 2));
            end_Copy.Content += "   " + q;
            string str = datauser.Status_IMT();
            end_Copy1.Content += " " + str;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            datauser.Set_height(Convert.ToInt32(height.Text));
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            datauser.Set_wieght(Convert.ToInt32(weight.Text)); 
        }

    }
}
