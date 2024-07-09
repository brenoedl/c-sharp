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

namespace SorteiaWpf
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

        private async void btnSortear_Click(object sender, RoutedEventArgs e)
        {
            int inicio = 0, fim = 0;
            Random rand = new Random();
            int.TryParse(txtInicio.Text, out inicio);
            int.TryParse(txtFim.Text, out fim);
            int gerador = rand.Next(inicio, fim + 1);
            lblMsg.Visibility = Visibility.Visible;
            await Task.Delay(2000);
            lblMsg.Content = $"Sorteando entre {inicio} e {fim}...";
            await Task.Delay(2000);
            lblMsg.Content = $"Sortiei o valor {gerador}...";
        }
    }
}