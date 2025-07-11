using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DemantApp
{
    internal class SpecificViewModel : MainWindowViewModel
    {
        public ICommand ConvertCommand { get; set; }
        public string InputText { get; set; } = string.Empty;
        public string ResultText { get; set; } = string.Empty;

        public SpecificViewModel()
        {
            ConvertCommand = new RelayCommand(ConvertButton_Click);
        }

        /// <summary>
        /// converts kilometers to miles when the button is clicked, rounding the result to 4 decimal places
        /// </summary>
        private void ConvertButton_Click()
        {
            if (double.TryParse(InputText, out double number))
            {
                ResultText= Math.Round((number / 1.60934), 4).ToString();
            }
            else
            {
                ResultText = "Invalid input";
            }
            
            OnPropertyChanged(nameof(ResultText));
        }
    }
}
