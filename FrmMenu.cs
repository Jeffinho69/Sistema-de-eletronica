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
using MySql.Data.MySqlClient;

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
            
        }

        

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtSystem_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            LabelRelogio.Text = DateTime.Now.ToString(" HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LabelData.Text = DateTime.Now.ToString(" dd/MM/yyyy");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        
        
    }
}
