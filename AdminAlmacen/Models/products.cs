//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminAlmacen.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public products()
        {
            this.invoice_detail = new HashSet<invoice_detail>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public int quatity_tot { get; set; }
        public int quantity_min { get; set; }
        public int price { get; set; }
        public int cost { get; set; }
        public int id_provider { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<invoice_detail> invoice_detail { get; set; }
        public virtual provider provider { get; set; }
    }
}
