using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _19._02._24_1_ZAD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeColor_Click(object sender, RoutedEventArgs e)
        {
            if (Maingrid.Background == Brushes.LightGray)
            {
                Maingrid.Background = Brushes.LightBlue;
            }
            else
            {
                Maingrid.Background = Brushes.LightGray;
            }
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("блабалбалбалаблаблаблабл", "About");
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
    }
}
