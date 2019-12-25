//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class CatCatalog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CatCatalog()
        {
            this.Products = new HashSet<Product>();
        }
    
        public int IdCatalog { get; set; }
        public Nullable<int> IdProvider { get; set; }
        public string Season { get; set; }
        public Nullable<System.DateTime> StarActiveDate { get; set; }
        public Nullable<System.DateTime> EndActiveDate { get; set; }
        public Nullable<System.DateTime> DateUpdate { get; set; }
        public bool IsEnabled { get; set; }
    
        public virtual CatProvider CatProvider { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}