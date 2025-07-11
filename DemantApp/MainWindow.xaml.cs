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
            DataContext = new SpecificViewModel();
            InitializeComponent();
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