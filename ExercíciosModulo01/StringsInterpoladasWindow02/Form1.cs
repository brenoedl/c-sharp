namespace StringsInterpoladasWindow02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            float sal = 0;
            float.TryParse(txtSal.Text, out sal);
            lblMsg.Visible = true;
            lblMsg.Text = $"Você ganhar {sal:c} por mês";
        }
    }
}
