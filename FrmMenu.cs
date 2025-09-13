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

namespace AppSistema1
{
    public partial class FrmMenu : Form
    {
    

        Thread ntProdutos, ntCliente,ntEstoque;
        public FrmMenu()
        {
            InitializeComponent();

        }


        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ntProdutos = new Thread(novoFrmProdutos);
            ntProdutos.SetApartmentState(ApartmentState.STA);
            ntProdutos.Start();
        }

        private void novoFrmProdutos()
        {
            Application.Run(new FrmProdutos());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            ntEstoque = new Thread(novoFrmEstoque);
            ntEstoque.SetApartmentState(ApartmentState.STA);
            ntEstoque.Start();
        }

        private void novoFrmEstoque()
        {
            Application.Run(new FrmEstoque());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtSystem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LabelRelogio.Text = DateTime.Now.ToString("(dd/MM/yyyy) | (HH:mm:ss)");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            ntCliente = new Thread(novoFrmClientes);
            ntCliente.SetApartmentState(ApartmentState.STA);
            ntCliente.Start();
        }

        private void novoFrmClientes()
        {
            Application.Run(new FrmCliente());
        }
    }
}
