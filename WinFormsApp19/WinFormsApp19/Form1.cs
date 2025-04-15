namespace WinFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYakala_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();

            btnYakala.Left = random.Next(0,501);
            btnYakala.Top = random.Next(0, 501);
        }
    }
}
