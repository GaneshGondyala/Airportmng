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
    
    public partial class ManagerTable
    {
        public string Name { get; set; }
        public string SSN { get; set; }
        public System.DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string AddressId { get; set; }
        public string ManagerId { get; set; }
        public string password { get; set; }
    
        public virtual Addresstable Addresstable { get; set; }
    }
}