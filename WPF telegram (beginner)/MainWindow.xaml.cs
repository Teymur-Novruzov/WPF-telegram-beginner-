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

namespace WPF_telegram__beginner_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Messages messages_mia = new Messages();
        public int count_mia;
        
        Messages messages_Ali = new Messages();
        public int count_ali;
        
        Messages messages_john = new Messages();
        public int count_john;

        public string check_mia;
        public MainWindow()
        {
            Message_base();
            InitializeComponent();
        }

        public void Message_base()
        {
            messages_mia.messages[0] = "fine";
            messages_mia.messages[1] = "how are you Mia";
            messages_mia.messages[3] = "hi Mia";
            messages_mia.messages[2] = "hello X";
            count_mia = 4;

            messages_Ali.messages[0] = "fine";
            messages_Ali.messages[1] = "how are you Ali";
            messages_Ali.messages[3] = "hi Ali";
            messages_Ali.messages[2] = "hello X";
            count_ali = 4;

            messages_john.messages[0] = "fine";
            messages_john.messages[1] = "how are you John";
            messages_john.messages[3] = "hi John";
            messages_john.messages[2] = "hello X";
            count_john = 4;

        }
        private void mia_lbl_Click_mia(object sender, RoutedEventArgs e)
        {

            show_message("M");
            mia_lbl.Background = Brushes.LightBlue;
            john_lbl.Background = Brushes.White;
            Ali_lbl.Background = Brushes.White;
            name_lbl.Content = mia_lbl.Content;
        }
        private void john_lbl_Click(object sender, RoutedEventArgs e)
        {
            show_message("J");
            mia_lbl.Background = Brushes.White;
            john_lbl.Background = Brushes.LightBlue;
            Ali_lbl.Background = Brushes.White;
            name_lbl.Content = john_lbl.Content;

        } 
        private void Ali_lbl_Click(object sender, RoutedEventArgs e)
        {

            show_message("A");
            mia_lbl.Background = Brushes.White;
            john_lbl.Background = Brushes.White;
            Ali_lbl.Background = Brushes.LightBlue;
            name_lbl.Content = Ali_lbl.Content;
        }
        public void add_message(string text)
        {

            int count_add = 0;
            Messages new_mesaj = new Messages();

            if (text == "A")
            {
                new_mesaj = messages_Ali;
                count_add = count_ali;
            }
            else if (text == "J")
            {
                new_mesaj = messages_john;
                count_add = count_john;
            }
            else if (text == "M")
            {
                new_mesaj = messages_mia;
                count_add = count_mia;
            }


            if (Lbl_7.HorizontalAlignment == HorizontalAlignment.Left)
            {
                Lbl_8.HorizontalAlignment = HorizontalAlignment.Left;
                Lbl_8.Content = Lbl_7.Content;
                new_mesaj.messages[6] = Lbl_8.Content.ToString();
                
            }
            else
            {
                Lbl_8.HorizontalAlignment = HorizontalAlignment.Right;
                Lbl_8.Content = Lbl_7.Content;
                new_mesaj.messages[6] = Lbl_8.Content.ToString();
                
            }
            
            if (Lbl_6.HorizontalAlignment == HorizontalAlignment.Left)
            {
                Lbl_7.HorizontalAlignment = HorizontalAlignment.Left;
                Lbl_7.Content = Lbl_6.Content;
                new_mesaj.messages[5] = Lbl_7.Content.ToString();
                
            }
            else
            {
                Lbl_7.HorizontalAlignment = HorizontalAlignment.Right;
                Lbl_7.Content = Lbl_6.Content;
                new_mesaj.messages[5] = Lbl_7.Content.ToString();
                

            }
            
            if (Lbl_5.HorizontalAlignment == HorizontalAlignment.Left)
            {
                Lbl_6.HorizontalAlignment = HorizontalAlignment.Left;
                Lbl_6.Content = Lbl_5.Content;
                new_mesaj.messages[4] = Lbl_6.Content.ToString();
                
            }
            else
            {
                Lbl_6.HorizontalAlignment = HorizontalAlignment.Right;
                Lbl_6.Content = Lbl_5.Content;
                new_mesaj.messages[4] = Lbl_6.Content.ToString();
                
            }
            
            if (Lbl_4.HorizontalAlignment == HorizontalAlignment.Left)
            {
                Lbl_5.HorizontalAlignment = HorizontalAlignment.Left;
                Lbl_5.Content = Lbl_4.Content;
                new_mesaj.messages[3] = Lbl_5.Content.ToString();
                
            }
            else
            {
                Lbl_5.HorizontalAlignment = HorizontalAlignment.Right;
                Lbl_5.Content = Lbl_4.Content;
                new_mesaj.messages[3] = Lbl_5.Content.ToString();
                
            }
            
            if (Lbl_3.HorizontalAlignment == HorizontalAlignment.Left)
            {
                Lbl_4.HorizontalAlignment = HorizontalAlignment.Left;
                Lbl_4.Content = Lbl_3.Content;
                new_mesaj.messages[2] = Lbl_4.Content.ToString();
                
            }
            else
            {
                Lbl_4.HorizontalAlignment = HorizontalAlignment.Right;
                Lbl_4.Content = Lbl_3.Content;
                new_mesaj.messages[2] = Lbl_4.Content.ToString();
                
            }
            
            if (Lbl_2.HorizontalAlignment == HorizontalAlignment.Left)
            {
                Lbl_3.HorizontalAlignment = HorizontalAlignment.Left;
                Lbl_3.Content = Lbl_2.Content;
                new_mesaj.messages[1] = Lbl_3.Content.ToString();
                
            }
            else
            {
                Lbl_3.HorizontalAlignment = HorizontalAlignment.Right;
                Lbl_3.Content = Lbl_2.Content;
                new_mesaj.messages[1] = Lbl_3.Content.ToString();
                
            }

            Lbl_2.HorizontalAlignment = HorizontalAlignment.Right;
            Lbl_2.Content = message_text.Text;
            new_mesaj.messages[0] = Lbl_2.Content.ToString();
            ++count_add;


            if (text == "A")
            {
                messages_Ali= new_mesaj;
                count_ali= count_add;
            }
            else if (text == "J")
            {
                
                messages_john = new_mesaj;
                count_john = count_add;
            }
            else if (text == "M")
            {
                
                messages_mia = new_mesaj;
                count_mia = count_add;
            }



        }
        public void show_message(string text)
        {
            Lbl_2.Content = " ";
            Lbl_3.Content = " ";
            Lbl_4.Content = " ";
            Lbl_5.Content = " ";
            Lbl_6.Content = " ";
            Lbl_7.Content = " ";
            Lbl_8.Content = " ";

            int count = 0;
            Messages new_mesaj = new Messages();
            if (text == "A")
            {
                new_mesaj = messages_Ali;
                count = count_ali;
            }
            else if(text == "J")
            {
                new_mesaj = messages_john;
                count = count_john;
            }
            else if(text == "M")
            {
                new_mesaj = messages_mia;
                count = count_mia;
            }


            if (count > 0)
            {

            Lbl_2.Content = new_mesaj.messages[0];
            } 
            if (count > 1)
            {

            Lbl_3.Content = new_mesaj.messages[1];
            }
            if (count > 2)
            {

            Lbl_4.Content = new_mesaj.messages[2];
            }
            if (count > 3)
            {

            Lbl_5.Content = new_mesaj.messages[3];
            }
            if (count > 4)
            {

            Lbl_6.Content = new_mesaj.messages[4];
            }
            if (count > 5)
            {

            Lbl_7.Content = new_mesaj.messages[5];
            }
            if (count > 6)
            {

            Lbl_8.Content = new_mesaj.messages[6];
            }
            
        }

        private void Button_Click_sent_btn(object sender, RoutedEventArgs e)
        {
            string change = "";
            if (name_lbl.Content.ToString() == "JOHN")
            {
                change = "J";
            }
            else if(name_lbl.Content.ToString() == "Mia")
            {
                change = "M";
            } 
            else if(name_lbl.Content.ToString() == "Ali")
            {
                change = "A";
            }
            add_message(change);
            message_text.Text = "";
        }

      

        private void message_text_MouseEnter(object sender, MouseEventArgs e)
        {
            if (message_text.Text == "Write a message ...")
            {

                message_text.Text = "";
            }
        }

        private void message_text_MouseLeave(object sender, MouseEventArgs e)
        {
            if (message_text.Text == "")
            {

                message_text.Text = "Write a message ...";
            }
        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            if (search_txb.Text == "Search")
            {

                search_txb.Text = "";
            }

        }

        private void TextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            if (search_txb.Text == "")
            {

                search_txb.Text = "Search";
            }
        }

        private void Button_Click_search(object sender, RoutedEventArgs e)
        {
            if (search_txb.Text == john_lbl.Content.ToString())
            {
                john_lbl.Background = Brushes.Red;
            } 
            if (search_txb.Text == mia_lbl.Content.ToString())
            {
                mia_lbl.Background = Brushes.Red;
            } 
            if (search_txb.Text == Ali_lbl.Content.ToString())
            {
                Ali_lbl.Background = Brushes.Red;
            }
            
        }
    }
    public class Messages
    {
        public string[] messages = new string[7];
        
    }
}
