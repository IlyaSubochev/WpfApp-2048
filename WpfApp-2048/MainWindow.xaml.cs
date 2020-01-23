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
using Game2048;


namespace WpfApp_2048
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Model model;
        public MainWindow()
        {
            InitializeComponent();
            model = new Model(4);
        }
        void Show(Model model)
        {
            for (int x = 0; x < model.size; x++)
                for (int y = 0; y < model.size; y++)
                {
                    Find("b" + y + x, model.GetMap(x, y));
                }
            if (model.IsGameOver())
                informText.Text = "Game Over";
            else
                informText.Text = "Готов к труду и обороне";
        }
        void Find(string name, int number)
        {
            object findButton = Panel.FindName(name);
            if (findButton is Button)
            {
                Button bt = findButton as Button;
                bt.Content = number.ToString();
                switch (number)
                {
                    case 0:
                        bt.Background = new SolidColorBrush(Colors.Gray);
                        break;
                    case 2:
                        bt.Background = new SolidColorBrush(Colors.Aqua);
                        break;
                    case 4:
                        bt.Background = new SolidColorBrush(Colors.Goldenrod);
                        break;
                    case 8:
                        bt.Background = new SolidColorBrush(Colors.Green);
                        break;
                    case 16:
                        bt.Background = new SolidColorBrush(Colors.GreenYellow);
                        break;
                    case 32:
                        bt.Background = new SolidColorBrush(Colors.Orange);
                        break;
                    case 64:
                        bt.Background = new SolidColorBrush(Colors.MediumAquamarine);
                        break;
                    case 128:
                        bt.Background = new SolidColorBrush(Colors.Purple);
                        break;
                    case 256:
                        bt.Background = new SolidColorBrush(Colors.Yellow);
                        break;
                    case 512:
                        bt.Background = new SolidColorBrush(Colors.IndianRed);
                        break;
                    case 1024:
                        bt.Background = new SolidColorBrush(Colors.PapayaWhip);
                        break;
                    case 2048:
                        bt.Background = new SolidColorBrush(Colors.OrangeRed);
                        break;
                }
            }
           
        }
       

        private void ExitMenuItem_OnClick(object Sender, RoutedEventArgs E)
        {
            Close();
        }

        private void btUp_Click(object sender, RoutedEventArgs e)
        {
            model.Up();
            Show(model);
        }

        private void btDown_Click(object sender, RoutedEventArgs e)
        {
            model.Down();
            Show(model);
        }

        private void btLeft_Click(object sender, RoutedEventArgs e)
        {
            model.Left();
            Show(model);
        }

        private void btRight_Click(object sender, RoutedEventArgs e)
        {
            model.Right();
            Show(model);
        }

        private void newGame_Click(object sender, RoutedEventArgs e)
        {
            model.Start();
            Show(model);
        }
    }
}
