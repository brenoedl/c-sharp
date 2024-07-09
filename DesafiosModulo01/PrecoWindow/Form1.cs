namespace PrecoWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            string produto1, produto2;
            float pre�o1 = 0, pre�o2 = 0;
            produto1 = txtProduto1.Text;
            float.TryParse(txtPreco1.Text, out pre�o1);
            produto2 = txtProduto2.Text;
            float.TryParse(txtPreco2.Text, out pre�o2);
            panMsg.Visible = true;
            lblMsg1.BackColor = Color.DarkBlue;
            lblMsg1.ForeColor = Color.White;
            lblMsg1.Text = $"{"Produto",-20}{"Pre�o",13}";
            lblMsg2.BackColor = Color.DarkGray;
            lblMsg2.ForeColor = Color.Black;
            lblMsg2.Text = $"{produto1,-20}{pre�o1,13:c2}";
            lblMsg3.BackColor = Color.DarkGray;
            lblMsg3.ForeColor = Color.Black;
            lblMsg3.Text = $"{produto2,-20}{pre�o2,13:c2}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
