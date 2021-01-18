//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusWebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class bus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public bus()
        {
            this.bookings = new HashSet<booking>();
            this.busSeatMaps = new HashSet<busSeatMap>();
            this.CustomerSeatMaps = new HashSet<CustomerSeatMap>();
        }
    
        public int BusId { get; set; }
        public Nullable<int> RouteId { get; set; }
        public string AgencyNAme { get; set; }
        public string BusType { get; set; }
        public System.TimeSpan DepartureTime { get; set; }
        public System.TimeSpan ArrivalTime { get; set; }
        public Nullable<int> Fare { get; set; }
        public Nullable<byte> NoOfSeats { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<booking> bookings { get; set; }
        public route route { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<busSeatMap> busSeatMaps { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<CustomerSeatMap> CustomerSeatMaps { get; set; }
    }
}
