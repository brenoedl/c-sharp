namespace EntradaDadosWindow01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            lblMsg.Visible = true;
            lblMsg.Text = "Muito prazer em te conhecer, " + nome + "!";
        }
    }
}
