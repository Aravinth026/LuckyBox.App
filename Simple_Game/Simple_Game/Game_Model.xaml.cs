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
using System.Windows.Shapes;

namespace Simple_Game
{
    /// <summary>
    /// Interaction logic for Game_Model.xaml
    /// </summary>
    public partial class Game_Model : Window
    {
        int count = 0;
        public Game_Model()
        {
            InitializeComponent();
        }

        private void Overall_Click(object sender, RoutedEventArgs e)
        {
            count++;
         
            Button btnbox = (Button)sender;
            btnbox.Content = btnbox.Tag;
            btnbox.IsEnabled = false;

            if(lblplayer1.Tag.ToString()=="1")
            {
                int prevamount = Convert.ToInt32(txtplayer1.Text);
                int currentamount = Convert.ToInt32(btnbox.Tag);
                int totalamount = prevamount + currentamount;

                txtplayer1.Text=totalamount.ToString();
                btnbox.Foreground = txtplayer1.Foreground;  
                
                lblplayer1.Tag = "0";
                lblplayer2.Tag = "1";

            }
            else if (lblplayer2.Tag.ToString() == "1")
            {
                int prevamount = Convert.ToInt32(txtplayer2.Text);
                int currentamount = Convert.ToInt32(btnbox.Tag);
                int totalamount = prevamount + currentamount;

                txtplayer2.Text = totalamount.ToString();
                btnbox.Foreground = txtplayer2.Foreground;

                lblplayer1.Tag = "1";
                lblplayer2.Tag = "0";

            }

            if(count == 50)
            {
                int player1 = Convert.ToInt32(txtplayer1.Text);
                int player2 = Convert.ToInt32(txtplayer2.Text);
                if(player1> player2)
                {
                    MessageBox.Show(lblplayer1.Content +" is Winner");
                }
                else
                {
                    MessageBox.Show(lblplayer2.Content + " is Winner");
                }

                
                                        
            }
            
        }
    }
}
