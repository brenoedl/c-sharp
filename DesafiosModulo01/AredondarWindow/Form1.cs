namespace AredondarWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            float num = 0;
            int arredomdar = 0;
            int parte = 0;
            float.TryParse(txtNum.Text, out num);
            parte = (int)num;
            arredomdar = Convert.ToInt16(num);
            lblMsg1.Text = $"Você digitou o valor {num:n}.";
            lblMsg2.Text = $"A parte inteira é {parte:d}.";
            lblMsg3.Text = $"Arredondando, temos o valor {arredomdar:d}.";
            panMsg.Visible = true;
        }
    }
}
