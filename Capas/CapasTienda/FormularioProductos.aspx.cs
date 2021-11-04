using CDatos;
using CEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapasTienda
{
    public partial class FormularioProductos : System.Web.UI.Page
    {
        CDProducto oproducto = new CDProducto();
        CEProducto cEProducto = new CEProducto();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGuardar(object sender, EventArgs e)
        {
            cEProducto.codigo_producto = Convert.ToString(txtCodigoProducto.Text);
            cEProducto.Nombre = Convert.ToString(txtNombreProducto);
            cEProducto.Cantidad = Convert.ToInt32(txtCantidad);
            cEProducto.Precio = Convert.ToInt32(txtPrecio);
            cEProducto.Id_producto = Convert.ToInt32(txtID);
            cEProducto.Categoria = Convert.ToString(txtCategoria);

            if (oproducto.Guardar_producto(cEProducto))
            {

                lblResultado.Text = "se guardo correctamente";

            }
            else {

                lblResultado.Text = "error al guardar";
            
            }


            
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            cEProducto.codigo_producto = Convert.ToString(txtCodigoProducto);

            ds = oproducto.consultar_cita(cEProducto);

            if (ds.Tables[0].Rows.Count == 0)
            {

                lblResultado.Text = "este producto de existe";

            }
            else {

                lblResultado.Text = ds.Tables[0].Rows[0]["codigo_producto"].ToString();
                txtID.Text = ds.Tables[0].Rows[0]["id_producto"].ToString();
                txtNombreProducto.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                txtCantidad.Text = ds.Tables[0].Rows[0]["cantidad"].ToString();
                txtPrecio.Text = ds.Tables[0].Rows[0]["precio"].ToString();
                txtCategoria.Text = ds.Tables[0].Rows[0]["categoria"].ToString();
            
            }

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            cEProducto.codigo_producto = Convert.ToString(txtCodigoProducto);

            if (oproducto.Anular_producto(cEProducto))
            {

                lblResultado.Text = "el producto se ha eliminado correctamente";

            }
            else {

                lblResultado.Text = "el producto no se ha eliminado";
            
            }


        }
    }
}