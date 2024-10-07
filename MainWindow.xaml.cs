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

namespace git_taak_1_groep_abc_Youssef_Mahtar
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

        private void Rood_MouseEnter(object sender, MouseEventArgs e)
        {
            MainGrid.Background = (Brush)new BrushConverter().ConvertFrom("#FF0000");
        }

        private void Groen_MouseEnter(object sender, MouseEventArgs e)
        {
            MainGrid.Background = (Brush)new BrushConverter().ConvertFrom("#008000");
        }

        private void Geel_MouseEnter(object sender, MouseEventArgs e)
        {
            MainGrid.Background = (Brush)new BrushConverter().ConvertFrom("#FFFF00");
        }

        private void Blauw_MouseEnter(object sender, MouseEventArgs e)
        {
            MainGrid.Background = (Brush)new BrushConverter().ConvertFrom("#0000FF");
        }

        private void Grijs_MouseLeave(object sender, MouseEventArgs e)
        {
            MainGrid.Background = new SolidColorBrush(Colors.LightGray);
        }
    }
}
