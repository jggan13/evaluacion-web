using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginService.Entities
{
    public class Productos
    {
        public Productos(string id, string codigo, string descripcion, decimal precio, int cantidad, decimal total)
        {
            this.Id = id;
            this.Codigo = codigo;
            this.Descripcion = descripcion;
            this.PrecioVenta = precio;
            this.Cantidad = cantidad;
            this.Total = total;
        }

        public string Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
    }
}