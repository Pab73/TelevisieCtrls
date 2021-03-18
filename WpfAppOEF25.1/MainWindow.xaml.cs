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

namespace WpfAppOEF25._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            rbSamsung.IsChecked = true;
        }
        TV newTV = new TV();

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            lblTVgegevens.Content = "Merk:Samsung" + Environment.NewLine +
                "Type: 85Q980TS" + Environment.NewLine + "Herz: 100" + Environment.NewLine + "Beeldgrootte: 85";
            string packUri = "Images/400x320_Samsung.jpg";
            imgTV.Source = new ImageSourceConverter().ConvertFromString(packUri) as ImageSource;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            lblTVgegevens.Content = "Merk:Sony" + Environment.NewLine +
                "Type: KD-77AG9" + Environment.NewLine + "Herz: 100" + Environment.NewLine + "Beeldgrootte: 77";
            string packUri = "Images/Sony.jfif";
            imgTV.Source = new ImageSourceConverter().ConvertFromString(packUri) as ImageSource;
        }

        private void cbPower_Checked(object sender, RoutedEventArgs e)
        {
            newTV.Power = true;
            txtKanaal.Text = newTV.Kanaal.ToString();
            txtVolume.Text = newTV.Volume.ToString();
        }
        private void cbPower_Unchecked(object sender, RoutedEventArgs e)
        {
            newTV.Power = false;
            txtKanaal.Text = "";
            txtVolume.Text = "";
        }

        private void btnKanaalPlus_Click(object sender, RoutedEventArgs e)
        {
            if (newTV.Power)
            {
                newTV.Kanaal++;
                txtKanaal.Text = newTV.Kanaal.ToString();
            }
        }
        private void btnKanaalMin_Click(object sender, RoutedEventArgs e)
        {
            if (newTV.Power)
            {
                newTV.Kanaal--;
                //if (newTV.Kanaal < 0)
                //{
                //    newTV.Kanaal = 0;
                //}
                txtKanaal.Text = newTV.Kanaal.ToString();
            }
        }

        private void btnVolumeMin_Click(object sender, RoutedEventArgs e)
        {
            if (newTV.Power)
            {
                newTV.Volume--;
                //if (newTV.Volume < 0)
                //{
                //    newTV.Volume = 0;
                //}
                txtVolume.Text = newTV.Volume.ToString();
            }
        }

        private void btnVolumePlus_Click(object sender, RoutedEventArgs e)
        {
            if (newTV.Power)
            {
                newTV.Volume++;
            }
            txtVolume.Text = newTV.Volume.ToString();
        }
    }
}
