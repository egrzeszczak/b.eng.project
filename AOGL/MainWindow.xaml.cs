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

namespace AOGL
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

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            if(Tg_Btn.IsChecked == true)
            {
                tt_plik.Visibility = Visibility.Collapsed;
                tt_ustawienia.Visibility = Visibility.Collapsed;
                tt_laser.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_plik.Visibility = Visibility.Visible;
                tt_ustawienia.Visibility = Visibility.Visible;
                tt_laser.Visibility = Visibility.Visible;
            }
        }
    }
}
