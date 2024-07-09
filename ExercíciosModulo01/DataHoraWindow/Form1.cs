namespace DataHoraWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;
            int hora = DateTime.Now.Hour;
            int minuto = DateTime.Now.Minute;
            int segundo = DateTime.Now.Second;
            lblDH.Text = dia + "/" + mes + "/" + ano + " " + hora + ":" + minuto + ":" + segundo;
        }
    }
}
