using Sistema_Grifo.Calculadora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using GroupBox = System.Windows.Forms.GroupBox;

namespace Sistema_Grifo
{
    public partial class UserControl2 : System.Windows.Forms.UserControl
    {
        Calculos calc = new Calculos();
        Consulta consulta = new Consulta();
        public UserControl2()
        {
            InitializeComponent();
            gbspda.Enabled = false;
            gblaudo.Enabled = false;
            gbaterramento.Enabled = false;


        }

        private void tbservico_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cbservico.SelectedItem.ToString())
            {
                case "SPDA":
                    gbspda.Enabled = true;
                    gblaudo.Enabled = false;
                    gbaterramento.Enabled = false;
                    break;
                case "Laudo":
                    gblaudo.Enabled = true;
                    gbspda.Enabled = false;
                    gbaterramento.Enabled = false;
                    break;
                case "Aterramento":
                    gbaterramento.Enabled = true;
                    gblaudo.Enabled = false;
                    gbspda.Enabled = false;
                    break;
                default:
                    gbspda.Enabled = false;
                    gblaudo.Enabled = false;
                    gbaterramento.Enabled = false;
                    break;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bnovo_Click(object sender, EventArgs e)
        {
            bnovo.Enabled = false;
            cbservico.Enabled = true;
        }

        private void balterar_Click(object sender, EventArgs e)
        {

        }

        private void cbmaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void bsalvar_Click(object sender, EventArgs e)
        {

        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbaterramento_CheckedChanged(object sender, EventArgs e)
        {
            calc.aterramento();
        }

        private void rbdescidas_CheckedChanged(object sender, EventArgs e)
        {
            calc.descidas();
        }

        private void rbcaptor_CheckedChanged(object sender, EventArgs e)
        {
            calc.Captor();
        }

        private void cbtab_SelectedIndexChanged(object sender, EventArgs e)
        {
            consulta.consultarDados();

        }

        private void tbconsulta_TextChanged(object sender, EventArgs e)
        {
            consulta.consultarDados();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void dgvconsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbtab_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            consulta.consultarDados();
        }
    }
}
