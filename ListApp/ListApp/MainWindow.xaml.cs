using System;
using System.Collections;
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

namespace ListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ArrayList list;
        public MainWindow()
        {
            InitializeComponent();
            list = new ArrayList();
        }

        //Add Data
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            list.Add(txtBox.Text);
            MessageBox.Show("Added " + txtBox.Text.ToString());
        }

        //Remove Data
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            list.Remove(txtBox.Text);
            MessageBox.Show("Remove " + txtBox.Text.ToString());
        }

        //Show Data
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("No data found. Please fill in something.");
            }
            else
            {
                for (var data = 0; data < list.Count; data++) 
                {
                    MessageBox.Show("Data " + (data+1).ToString() + " = " + list[data].ToString());
                }
            }

        }

        //Count Data
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Count " + list.Count.ToString());
        }

        //Clear Data
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            list.Clear();
            MessageBox.Show("All cleared. Nothing left.");
        }
    }
}
