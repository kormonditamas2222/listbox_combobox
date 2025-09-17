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
        List<string> elemek = ["alma", "banán", "körte"];
        public MainWindow()
        {
            InitializeComponent();
            lbox_1.ItemsSource = elemek;
        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            string ujElem = tb_1.Text.Trim();
            if (!string.IsNullOrEmpty(ujElem)) 
            { 
                elemek.Add(ujElem);
                lbox_1.Items.Refresh();
                tb_1.Clear();
            }
            else
            {
                MessageBox.Show(this, "A mezőt kötelező kitölteni!", "Hiba", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}