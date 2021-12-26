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

namespace Tsk4WpfApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDollar = rateDollar * sumDollar;
            resSum.Text = resDollar.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate1.Text);
            double sumEuro = Convert.ToDouble(sum1.Text);
            double resEuro = rateEuro * sumEuro;
            resSum1.Text = resEuro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGriv = Convert.ToDouble(rate2.Text);
            double sumGriv = Convert.ToDouble(sum2.Text);
            double resGriv = rateGriv * sumGriv;
            resSum2.Text = resGriv.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDrum = Convert.ToDouble(rate3.Text);
            double sumDrum = Convert.ToDouble(sum3.Text);
            double resDrum = rateDrum * sumDrum;
            resSum3.Text = resDrum.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double rateDu = Convert.ToDouble(rateD.Text);
            resD.Text = (rateDu * 0.0254).ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double rateFu = Convert.ToDouble(rateF.Text);
            resF.Text = (rateFu * 0.3048).ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double rateMi = Convert.ToDouble(rateM.Text);
            resM.Text = (rateMi * 1609.34).ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {

            double rateVe = Convert.ToDouble(rateV.Text);
            resV.Text = (rateVe * 1066.8).ToString();
        }
    }
}
