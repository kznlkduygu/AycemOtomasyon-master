//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AycemOtomasyon
{
    using System;
    using System.Collections.Generic;
    
    public partial class Porduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Porduct()
        {
            this.OrderItem = new HashSet<OrderItem>();
        }
    
        public System.Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public Nullable<System.Guid> ColourId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}