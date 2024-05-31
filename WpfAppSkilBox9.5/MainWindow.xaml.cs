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

namespace WpfAppSkilBox9._5
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

        private void buttonOne_Click(object sender, RoutedEventArgs e)
        {
            string inputUserBox = inputUser.Text;
            listBox.ItemsSource = inputUserBox.Split(" ");
        }

        private void buttonTwo_Click(object sender, RoutedEventArgs e)
        {
            string inputUserBox = inputUser.Text;
            string reversText = new string(inputUserBox.Reverse().ToArray());
            labelText.Content = reversText;

        }
    }
}