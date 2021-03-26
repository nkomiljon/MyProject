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

namespace MyProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            listBox1.Items.Add("   ID       Name             Price               Description       Data");
        }
        //TODO:how about creating seperate class for Foods class
        class Foods
        {
        //TODO:On first app load go set id to the last id in the db - maybe you can make a static method
            public int Id;
            public string FDName;
            public int FDPrice;
            public string FDDesc;
            public string Date;

            
        }
        int count = 1;
        string Error = "Error";
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Foods fd = new Foods();

            
            fd.FDName = textBox1.Text;
            if(fd.FDName == "")
            {
                labelError.Content = "Номро дохил кунед!";
            }
            else
            {
                labelError.Content = "";
            }
            if (textBox2.Text == "")
            {
                labelError2.Content = "Нархро дохил кунед!";
            }
            else
            {
                fd.FDPrice = int.Parse(textBox2.Text);
                labelError2.Content = "";
            } 
            fd.FDDesc = textBox3.Text;
            if (fd.FDDesc == "")
            { 
                labelError3.Content = "Малумотро дохил кунед!";
            }
            else
            {
                
                labelError3.Content = "";
              
                    fd.Id = count++;
                    // fd.Date = dataPicker1.SelectedDate.ToString();
                    listBox1.Items.Add("   " + fd.Id + "         " + fd.FDName + "          " + fd.FDPrice + "                  " + fd.FDDesc + "    " + fd.Date);
               
            }
            fd.Date = dataPicker1.SelectedDate.ToString();
            /* if (fd.FDName != "" &&  fd.FDDesc != "" && fd.FDPrice != 0)
             {
                 listBox1.Items.Add("   " + fd.Id + "        " + fd.FDName + "          " + fd.FDPrice + "                  " + fd.FDDesc + "    " + fd.Date);

                 //MessageBox.Show("???");
             }
             else {
                  labelError.Content = Error;
                 MessageBox.Show("???");
                 //                listBox1.Items.Add("   " + fd.Id + "      " + fd.FDName + "          " + fd.FDPrice + "                  " + fd.FDDesc + "    " + fd.Date);
             }
            */
            // MessageBox.Show(text);
        }
    }
}



