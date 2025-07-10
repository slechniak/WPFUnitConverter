using System.Windows;

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

        /// <summary>
        /// converts kilometers to miles when the button is clicked, rounding the result to 4 decimal places
        /// </summary>
        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(InputTextBox.Text, out double number))
            {
                ResultTextBox.Text = Math.Round((number / 1.60934), 4).ToString();
            }
            else
            {
                ResultTextBox.Text = "Invalid input";
            }
        }

        /// <summary>
        /// sets focus to the input textbox when the window is loaded, so it does not require a click to start typing
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            InputTextBox.Focus();
        }
    }
}