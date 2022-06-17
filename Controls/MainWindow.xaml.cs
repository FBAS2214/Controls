using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Controls
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // listBox.ItemsSource = GetString();


            // frame.Source = new Uri("https://www.google.com/");

        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var lBox = sender as ListBox;
            MessageBox.Show(lBox.SelectedValue.ToString());
        }









        private List<string> GetString()
        => new List<string>
            {
                "Leyla",
                "Ceyhun",
                "Nihad",
                "Ferman",
                "Elgun",
                "Nihat",
                "Kenan",
                "Sebine"
            };




        public int Counter { get; set; }
        private void rBtn_Click(object sender, RoutedEventArgs e)
        {
            //var btn = sender as RepeatButton;
            //// btn.Content = Counter++.ToString();


            //if (btn.Content.ToString() == "Up")
            //{
            //    if (pBar.Value < pBar.Maximum)
            //        pBar.Value++;
            //}
            //else
            //   if (pBar.Value > pBar.Minimum)
            //    pBar.Value--;

        }



        private void togBtn_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(togBtn.IsChecked.ToString());
        }
    }
}
