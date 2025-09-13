using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace projeto_1
{
    public partial class FrmCadastro : Form
    {
        Thread nt;
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(novoFrmmenu);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }

        private void novoFrmmenu()
        {
            Application.Run(new Frmmenu());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txttelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario Cadastrado!");
        }
    }
    }

    
