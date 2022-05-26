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
using SinCos;

namespace WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
            SiCo a = new SiCo();
            SiCo b = new SiCo();
            SiCo c = new SiCo();
            a.X = Convert.ToDouble(txtA.Text);
            b.X = Convert.ToDouble(txtB.Text);
            c.X = Convert.ToDouble(txtC.Text);
            txbA.Text = Convert.ToString(Math.Round(a.Calc(), 5));
            txbB.Text = Convert.ToString(Math.Round(b.Calc(), 5));
            txbC.Text = Convert.ToString(Math.Round(c.Calc(), 5));
            txbMin.Text = Math.Round(Math.Min(Math.Min(a.Calc(), b.Calc()), c.Calc()), 5).ToString();

        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txbA.Text = "";
            txbB.Text = "";
            txbC.Text = "";
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txbMin.Text = "";
        }
    }
}
