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

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void ValidateEmpleado(out int id,string nombre, out int existencia, string marca, string modelo, out decimal precio, string descripcion,string imagen)
        {
            if (!int.TryParse(txtID.Text, out int i))
            {
                throw new ArgumentException($"El valor \"{txtSalario.Text}\" es invalido!");
            }
            id = i;
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre es requerido!");
            }
            if (string.IsNullOrWhiteSpace(apellido))
            {
                throw new ArgumentException("El apellido es requerido!");
            }
            if (string.IsNullOrWhiteSpace(cedula))
            {
                throw new ArgumentException("La cedula es requerido!");
            }
            if (string.IsNullOrWhiteSpace(telefono))
            {
                throw new ArgumentException("El telefono es requerido!");
            }
            if (ValidateTelefono(telefono))
            {
                throw new ArgumentException("El telefono no tiene una estructura valida!");
            }
            if (string.IsNullOrWhiteSpace(correo))
            {
                throw new ArgumentException("El correo es requerido!");
            }
            if (!ValidateCorreo(correo))
            {
                throw new ArgumentException("El correo no tiene una estructura valida!");
            }
            if (!decimal.TryParse(txtSalario.Text, out decimal s))
            {
                throw new ArgumentException($"El valor \"{txtSalario.Text}\" es invalido!");
            }
            salario = s;
        }
    }
}
