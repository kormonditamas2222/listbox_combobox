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
        List<string> balLista = [];
        List<string> jobbLista = [];
        public MainWindow()
        {
            InitializeComponent();
            balLista.Add("elem");
            balLista.Add("hát");
            balLista.Add("gömb");
            balLista.Add("volt");
            lb_bal.ItemsSource = balLista;
            lb_jobb.ItemsSource = jobbLista;
        }

        private void btn_jobbra_Click(object sender, RoutedEventArgs e)
        {
            var kijelolt = lb_bal.SelectedItems.Cast<string>().ToList();
            foreach (var item in kijelolt)
            {
                balLista.Remove(item);
                jobbLista.Add(item);
            }
            lb_bal.Items.Refresh();
            lb_jobb.Items.Refresh();
        }

        private void btn_balra_Click(object sender, RoutedEventArgs e)
        {
            var kijelolt = lb_jobb.SelectedItems.Cast<string>().ToList();
            foreach (var item in kijelolt)
            {
                jobbLista.Remove(item);
                balLista.Add(item);
            }
            lb_bal.Items.Refresh();
            lb_jobb.Items.Refresh();
        }
    }
}