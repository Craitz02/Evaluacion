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
            string nombre = txtNombre.Text;
            int indexMarca = cmbMarca.SelectedIndex;
            Marcas marca = (Marcas)Enum.GetValues(typeof(Marcas)).GetValue(indexMarca);
            int indexModelo = cmbModelo.SelectedIndex;
            Modelos modelo = (Modelos)Enum.GetValues(typeof(Modelos)).GetValue(indexModelo);
            string descripcion = txtDescripcion.Text;
            string imagen = txtImagen.Text;
            ValidateProducto(out int id,nombre, out int existencia, out decimal precio, descripcion, imagen);

            Producto p = new Producto {
                Id = id,
                Nombre = nombre,
                Existencia = existencia,
                Marca = marca,
                Modelo= modelo,
                Precio= precio,
                Descripcion= descripcion,
                Imagen=imagen,



            };
            Productos.Add(p);
            

            
        }

        private void ValidateProducto(out int id,string nombre, out int existencia, out decimal precio, string descripcion,string imagen)
        {
            if (!int.TryParse(txtID.Text, out int i))
            {
                throw new ArgumentException($"El valor \"{txtID.Text}\" es invalido!");
            }
            id = i;
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre es requerido!");
            }
            if (!int.TryParse(txtExistencia.Text, out int exi))
            {
                throw new ArgumentException($"El valor \"{txtExistencia.Text}\" es invalido!");
            }
            existencia= exi;
            if (!int.TryParse(txtPrecio.Text, out int p))
            {
                throw new ArgumentException($"El valor \"{txtPrecio.Text}\" es invalido!");
            }
            precio= p;
            if (string.IsNullOrWhiteSpace(descripcion))
            {
                throw new ArgumentException("La descri´pcion es requerida!");
            }
            if (string.IsNullOrWhiteSpace(imagen))
            {
                throw new ArgumentException("La imagen es requerida!");
            }

           
        }
    }
}
