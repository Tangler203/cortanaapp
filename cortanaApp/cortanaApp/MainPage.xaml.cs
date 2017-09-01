using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Threading;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace cortanaApp
{
    
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public string test;
        private int targetnum;
        private Random r = new Random();
        Model m = new Model();
        public MainPage()
        {
            this.InitializeComponent();
            
            textBlock25.Text = m.getTargetNum().ToString();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            m.setTargetNum(r.Next(0, 100));
            textBlock25.Text = m.getTargetNum().ToString();
            checknum();
            guessbutton.IsEnabled = true;
            textBox1.Text = "";
            ResponseBlock.Text = "Guess the number by typing in the text box";
        }

        public bool checknum()
        {
            int guess = -1;

                if (textBox1.Text != "")
                {
                        guess = Convert.ToInt32(textBox1.Text);
                        if (guess > targetnum)
                        {
                            ResponseBlock.Text = "You guess is too high!";
                            return false;
                        }
                        else if (guess < targetnum)
                        {
                            ResponseBlock.Text = "You guess is too low!";
                            return false;
                        }

                        else
                        {
                            ResponseBlock.Text = guess + " is the correct number!";
                            return true;
                        }

                
                    }
            return false;
        }

        private void guessbutton_Click(object sender, RoutedEventArgs e)
        {
            if (checknum())
            {
                guessbutton.IsEnabled = false;
            }
            
        }

        public void setTextbox(string t)
        {
            textBox1.Text = t;
        }

        public void disableguess()
        {
            guessbutton.IsEnabled = false;
        }

       
    }
}
