namespace StringsInterpoladasFormatadasWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            int idade = 0;
            int.TryParse(txtIdade.Text, out idade);
            float peso = 0;
            float.TryParse(txtPeso.Text, out peso);
            lblMsg.Text = $"Olá, {nome} você tem {idade:d3} anos de idade e pesa {peso:n}Kg.";
            lblMsg.Visible = true;
        }
    }
}
