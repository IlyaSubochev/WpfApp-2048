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
            model.Start();
            Show(model);
        }
        void Show(Model model)
        {
            for (int x = 0; x < model.size; x++)
                for (int y = 0; y < model.size; y++)
                {
                    Find("b" + x + y, model.GetMap(x, y).ToString());
                }
        }
        void Find(string name, string number)
        {
            object findButton = Panel.FindName(name);
            if (findButton is Button)
            {
                Button bt = findButton as Button;
                bt.Content = number;
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
    }
}
