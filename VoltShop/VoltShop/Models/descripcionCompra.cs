//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VoltShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class descripcionCompra
    {
        public int id { get; set; }
        public Nullable<int> id_producto { get; set; }
        public Nullable<int> id_compra { get; set; }
        public Nullable<int> unidades { get; set; }
        public Nullable<double> total { get; set; }
    
        public virtual compras compras { get; set; }
        public virtual productos productos { get; set; }
    }
}
