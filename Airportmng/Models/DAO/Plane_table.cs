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
    
    public partial class Plane_table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Plane_table()
        {
            this.Plane_hanger = new HashSet<Plane_hanger>();
            this.Plane_pilot = new HashSet<Plane_pilot>();
        }
    
        public string RegistrationNo { get; set; }
        public string ModelNo { get; set; }
        public string Plane_Name { get; set; }
        public int Capacity { get; set; }
        public string Email { get; set; }
        public string Plane_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plane_hanger> Plane_hanger { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plane_pilot> Plane_pilot { get; set; }
        public virtual Planeowner_table Planeowner_table { get; set; }
    }
}
