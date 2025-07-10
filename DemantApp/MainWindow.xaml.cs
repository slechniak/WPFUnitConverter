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

namespace DemantApp
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

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(FromTextBox.Text, out double number))
            {
                ToTextBox.Text = (number / 1.609).ToString();
            }
            else
            {
                ToTextBox.Text = "Invalid input";
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FromTextBox.Focus();
        }
    }
}