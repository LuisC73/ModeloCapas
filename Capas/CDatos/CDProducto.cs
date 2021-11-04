using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidades;



namespace CDatos
{
    public class CDProducto
    {
        Cconexion oconexion = new Cconexion();
        SqlCommand ocmd = new SqlCommand();

        public bool Guardar_producto(CEProducto oproducto)
        {
 
            try 
            {

                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDTienda");
                ocmd.CommandText = "guardar_producto";
                ocmd.Parameters.Add("@id_producto", oproducto.Id_producto);
                ocmd.Parameters.Add("@nombre", oproducto.Nombre);
                ocmd.Parameters.Add("@cantidad", oproducto.Cantidad);
                ocmd.Parameters.Add("@precio", oproducto.Precio);
                ocmd.Parameters.Add("@categoria", oproducto.Categoria);
                ocmd.Parameters.Add("@activo", oproducto.Activo);

                ocmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public bool Anular_producto(CEProducto oproducto)
        {
            
            try 
            {

                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDTienda");
                ocmd.CommandText = "anular_producto";
                ocmd.Parameters.Add("@id_producto", oproducto.Id_producto);
                ocmd.ExecuteNonQuery();
                return true;

            }


            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public DataSet consultar_cita(object oECitas)
        {
            throw new NotImplementedException();
        }

        public DataSet Consultar_producto(CEProducto oproducto)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDTienda");
                ocmd.CommandText = "consultar_producto";
                ocmd.Parameters.Add("@id_producto", oproducto.Id_producto);
                SqlDataAdapter da = new SqlDataAdapter(ocmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;

            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
        }



    }
}
