namespace EntradaDadosWindow03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int num = 0;
            int.TryParse(txtNum.Text, out num);
            lblMsg.Text = "Voc� digitou o n�mero " + num;
            lblMsg.Visible = true;
        }
    }
}
