using Sistematico.poco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistematico
{
    public partial class FrmCatalogo : Form
    {
        public List<Producto> Productos { get; set; }
        public FrmCatalogo()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            FrmProducto frmProducto = new FrmProducto();
            frmProducto.Productos = Productos;
            _ = frmProducto.ShowDialog();


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvCatalogo.DataSource = null;
            dgvCatalogo.DataSource = Productos;
        }
    }
}
