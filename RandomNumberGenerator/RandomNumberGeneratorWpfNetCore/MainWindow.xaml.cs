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
using RandomNumberGeneratorLib;

namespace RandomNumberGeneratorWpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IRandomNumberGenerator rnd;

        public MainWindow()
        {
            InitializeComponent();

            Reset();
        }

        private void Btn_Generate_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Min.Text) || (!int.TryParse(Txt_Min.Text, out _)))
            {
                Txt_Min.Text = rnd.MinDefault.ToString();
            }
            if (string.IsNullOrWhiteSpace(Txt_Max.Text) || (!int.TryParse(Txt_Max.Text, out _)))
            {
                Txt_Max.Text = rnd.MaxDefault.ToString();
            }

            rnd.Min = Convert.ToUInt32(Txt_Min.Text);
            rnd.Max = Convert.ToUInt32(Txt_Max.Text);
            Txt_Max.Text = rnd.Max.ToString();

            Txt_Result.Text = rnd.GetValue().ToString();
        }

        private void Btn_Reset_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }

        void Reset()
        {
            rnd = new RandomNumberGenerator();
            Txt_Min.Text = rnd.Min.ToString();
            Txt_Max.Text = rnd.Max.ToString();
            Txt_Result.Clear();
        }
    }
}
