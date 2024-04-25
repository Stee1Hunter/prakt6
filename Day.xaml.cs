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

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            // Определение, какой RadioButton был выбран и отображение соответствующей картинки
            if (sender == image1RadioButton)
            {
                imageDisplay.Source = new BitmapImage(new Uri("image1.jpg", UriKind.Relative)); // Путь к первой картинке
            }
            else if (sender == image2RadioButton)
            {
                imageDisplay.Source = new BitmapImage(new Uri("image2.jpg", UriKind.Relative)); // Путь ко второй картинке
            }
            else if (sender == image3RadioButton)
            {
                imageDisplay.Source = new BitmapImage(new Uri("image3.jpg", UriKind.Relative)); // Путь к третьей картинке
            }
        }
    }
}
