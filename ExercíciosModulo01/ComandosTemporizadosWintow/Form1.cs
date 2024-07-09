namespace ComandosTemporizadosWintow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            int d = DateTime.Now.Day;
            int m = DateTime.Now.Month;
            int a = DateTime.Now.Year;
            lblMsg.Text = "Hoje é dia ";
            await Task.Delay(1000);
            lblMsg.Text += d;
            await Task.Delay(1000);
            lblMsg.Text += " do mês ";
            await Task.Delay(1000);
            lblMsg.Text += m;
            await Task.Delay(1000);
            lblMsg.Text += " de ";
            await Task.Delay(1000);
            lblMsg.Text += a;
        }
    }
}
