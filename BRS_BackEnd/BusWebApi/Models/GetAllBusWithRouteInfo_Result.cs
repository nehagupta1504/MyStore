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
    
    public partial class GetAllBusWithRouteInfo_Result
    {
        public int BusId { get; set; }
        public Nullable<int> RouteId { get; set; }
        public string AgencyNAme { get; set; }
        public string BusType { get; set; }
        public string Source { get; set; }
        public System.TimeSpan DepartureTime { get; set; }
        public string Destination { get; set; }
        public System.TimeSpan ArrivalTime { get; set; }
        public Nullable<int> Fare { get; set; }
        public Nullable<byte> NoOfSeats { get; set; }
    }
}