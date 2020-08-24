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

namespace Arraylist_84
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        ArrayList array_list;
       
      
        public MainWindow()
        {
            InitializeComponent();
            array_list = new ArrayList();
        }

        private void btn_add_click(object sender, RoutedEventArgs e)
        { 
                array_list.Add(txt_data.Text);
                txt_data.Clear();

             txt_data.Text = "";
        }

        private void btn_remove_Click(object sender, RoutedEventArgs e)
        {
            array_list.Remove(txt_data.Text);
                txt_data.Clear();
        }

        private void btn_show_click(object sender, RoutedEventArgs e)
        {  
                foreach (string data in array_list)
                {
                    MessageBox.Show(data.ToString(),"Show");
                }                
        }

        private void txt_data_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void data_gird_view1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
