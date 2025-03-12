using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlVentas
{
    public partial class frmVentas : Form
    {

        static string[] productos = { "Monitor", "CPU", "Teclado", "Mouse", "Parlantes", "Impresora", "Estabilizador" , "Mousepack"  };
        ArrayList aProductos = new ArrayList(productos);
        public frmVentas()
        {
            InitializeComponent();
        }
        private void frmVentas_Load(object sender, EventArgs e)
        {
            MostrarFecha();
            MostrarHora();
            LLenarProductos();
            LimpiarCampos();
        }
        private void MostrarFecha()
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
        private void MostrarHora() 
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }
        private void LimpiarCampos()
        {
            txtCliente.Clear();            
            cobProducto.Text = "Seleccione un Producto";
            txtCantidad.Clear();
            lblPrecio.Text = "0.00";
            txtCliente.Focus();
        }
        private void LLenarProductos()
        {
            foreach (var item in aProductos)
            {
                cobProducto.Items.Add(item);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
            DialogResult resul = MessageBox.Show("¿Desea salir?", "Ventas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resul==DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                LimpiarCampos();
            }            
            
        }
    }
}
