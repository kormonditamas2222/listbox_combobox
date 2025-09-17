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

namespace listboxok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<string> szinek = new List<string> {"Piros", "Zöld", "Skibidi"};

            cmb_1.ItemsSource = szinek;
        }

        private void cmb_1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmb_1.SelectedItem != null)
            {
                lb_out.Content = "Szín: " + cmb_1.SelectedItem.ToString();
            }
        }
    }
}