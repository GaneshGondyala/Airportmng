//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Airportmng.Models.DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Addresstable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Addresstable()
        {
            this.ManagerTables = new HashSet<ManagerTable>();
            this.Pilot_table = new HashSet<Pilot_table>();
            this.Planeowner_table = new HashSet<Planeowner_table>();
        }
    
        public string Hno { get; set; }
        public string Address_line1 { get; set; }
        public string City { get; set; }
        public string state { get; set; }
        public string Country { get; set; }
        public string pincode { get; set; }
        public string AddressId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ManagerTable> ManagerTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pilot_table> Pilot_table { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Planeowner_table> Planeowner_table { get; set; }
    }
}
