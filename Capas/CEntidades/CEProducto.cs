using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidades
{
    public class CEProducto
    {
        private int id_producto;
        private String nombre;
        private int cantidad;
        private int precio;
        private String categoria;
        private byte activo;

        public int Id_producto { get => id_producto; set => id_producto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public byte Activo { get => activo; set => activo = value; }
    }
}
