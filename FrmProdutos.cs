using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AppSistema1
{
    public partial class FrmProdutos : Form
    {
        Thread ntVoltar;
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            ntVoltar = new Thread(novoFrmMain);
            ntVoltar.SetApartmentState(ApartmentState.STA);
            ntVoltar.Start();
        }

        private void novoFrmMain()
        {
            Application.Run(new FrmMain());
        }
    }
}
