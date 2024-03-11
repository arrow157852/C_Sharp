using System.Windows.Forms;

namespace Sistema_Grifo
{
    public partial class Form1 : Form
    {
        private UserControl1 userControl1;
        public Form1()
        {

            InitializeComponent();
            Pnpainel.Visible = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pnpainel.Visible = true;
            Pnpainel.Controls.Clear(); // Limpa qualquer controle existente no painel antes de adicionar o UserControl1
            UserControl1 userControl1 = new UserControl1(); // Instancia o UserControl1
            userControl1.Dock = DockStyle.Fill; // Define o preenchimento do UserControl1 dentro do Panel
            Pnpainel.Controls.Add(userControl1); // Adiciona o UserControl1 ao PnPainel
            panel2.BringToFront();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Pnpainel.Visible = true;
            Pnpainel.Controls.Clear(); // Limpa qualquer controle existente no painel antes de adicionar o UserControl1
            UserControl2 userControl1 = new UserControl2(); // Instancia o UserControl1
            userControl1.Dock = DockStyle.Fill; // Define o preenchimento do UserControl1 dentro do Panel
            Pnpainel.Controls.Add(userControl1); // Adiciona o UserControl1 ao PnPainel
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }




}

