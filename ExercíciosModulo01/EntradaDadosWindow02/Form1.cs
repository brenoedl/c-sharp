namespace EntradaDadosWindow02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNumero.Text);
            lblMsg.Text = "Voc� digitou o n�mero " + num;
            lblMsg.Visible = true;
        }
    }
}
