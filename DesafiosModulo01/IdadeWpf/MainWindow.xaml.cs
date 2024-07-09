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

namespace IdadeWpf
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

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            int nasc = 0;
            int atual = DateTime.Now.Year;
            int idade;
            int.TryParse(txtNasc.Text, out nasc);
            idade = atual - nasc;
            lblMsg1.Content = $"Atualmente estamos em {atual:d}.";
            lblMsg2.Content = $"Se você nasceu {nasc:d}, vai ter {idade:d} anos.";
            panMsg.Visibility = Visibility.Visible;
        }
    }
}