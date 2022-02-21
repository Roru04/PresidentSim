using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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


namespace PresidentSim
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SoundPlayer player = new SoundPlayer("sounds/alexander-nakarada-chase.wav");

        public MainClass mainClass = new MainClass();

        

        public MainWindow()
        {
            InitializeComponent();
            player.PlayLooping();

            
           

        }

       
        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();

           
            MainMenu mainMenu = new MainMenu();

            
          

            mainMenu.Show();

           

            this.Close();

            
        }
        
    }
}
