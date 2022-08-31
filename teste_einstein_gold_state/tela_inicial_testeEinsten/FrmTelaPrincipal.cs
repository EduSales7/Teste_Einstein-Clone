using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tela_inicial_testeEinsten
{
    public partial class FrmTelaPrincipal : Form
    {
        
        public FrmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnFacil_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();

            
        }

        private void FrmTelaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
