using System.Windows.Forms;

namespace Sistema_Grifo
{
    public partial class Form1 : Form
    {
        private UserControl1 userControl1;
        public Form1()
        {

            InitializeComponent();

            PnRegistro.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {


            PnRegistro.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void PnRegistro_Load(object sender, EventArgs e)
        {

        }
    }




}

