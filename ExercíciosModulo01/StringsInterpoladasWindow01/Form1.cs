namespace StringsInterpoladasWindow01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblMsg.Visible = true;
            lblMsg.Text = $"O ano atual é {DateTime.Now.Year}";
        }
    }
}
