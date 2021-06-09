using Sistematico.enums;
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
    public partial class FrmProducto : Form
    {
        public List<Producto> Productos { get; set; }
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            cmbMarca.Items.AddRange(Enum.GetValues(typeof(Marcas))
                                        .Cast<object>()
                                       .ToArray());
            cmbMarca.SelectedIndex = 0;
            cmbModelo.Items.AddRange(Enum.GetValues(typeof(Modelos))
                                        .Cast<object>()
                                       .ToArray());
            cmbModelo.SelectedIndex = 0;
        }


    }
}
