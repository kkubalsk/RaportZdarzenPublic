//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RaportZdarzen
{
    using System;
    using System.Collections.Generic;
    
    public partial class TypyZdarzen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypyZdarzen()
        {
            this.Zdarzenia = new HashSet<Zdarzenia>();
        }
    
        public int IdTypZdarzenia { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public bool CzyZablokowany { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zdarzenia> Zdarzenia { get; set; }
    }
}
