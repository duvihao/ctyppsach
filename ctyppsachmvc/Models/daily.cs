//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ctyppsachmvc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class daily
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public daily()
        {
            this.congnotheothoigian = new HashSet<congnotheothoigian>();
            this.danhmucsachdaban = new HashSet<danhmucsachdaban>();
            this.hangtoncuadaily = new HashSet<hangtoncuadaily>();
            this.phieuxuat = new HashSet<phieuxuat>();
        }
    
        public int iddl { get; set; }
        public string tendl { get; set; }
        public string diachi { get; set; }
        public string sodt { get; set; }
        public Nullable<decimal> congno { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<congnotheothoigian> congnotheothoigian { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<danhmucsachdaban> danhmucsachdaban { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hangtoncuadaily> hangtoncuadaily { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<phieuxuat> phieuxuat { get; set; }
    }
}
