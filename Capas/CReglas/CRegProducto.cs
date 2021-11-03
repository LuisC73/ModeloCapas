using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CDatos;
using CEntidades;


namespace CReglas
{
    public class CRegProducto
    {
            CDProducto oproducto = new CDProducto();
        public bool guardar_producto(CEProducto oproducto)
        {
            return oproducto.Guardar_producto(oproducto);
        }
        public bool anular_producto(CEProducto oproducto)
        {
            return oproducto.Anular_producto(oproducto);
        }
        public DataSet consultar_producto(CEProducto oproducto)
        {
            return oproducto.Consultar_producto(oproducto);
        }

      }
   }

