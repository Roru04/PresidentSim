using System;
using System.Collections.Generic;
using System.Media;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PresidentSim
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public SoundPlayer player = new SoundPlayer("sounds/menuSound.wav");
        private bool musicIsOn;
        public MainMenu()
        {
            InitializeComponent();
            
            player.PlayLooping();
            musicIsOn = true;
            

        }

        private void Sound_Click(object sender, RoutedEventArgs e)
        {
           
          
            
            if (musicIsOn == true)
            {
                player.Stop();
               

                
                musicIsOn = false;
            }
            else
            {
                
              
                musicIsOn = true;
                player.Play();
            }
        }
    }
}
