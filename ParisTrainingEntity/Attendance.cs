//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ParisTrainingEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Attendance
    {
        public int ID { get; set; }
        public int StaffID { get; set; }
        public int SessID { get; set; }
        public Nullable<short> OutcomeID { get; set; }
        public string Comments { get; set; }
        public Nullable<int> BookedByStaffID { get; set; }
        public Nullable<System.DateTime> Created { get; set; }
        public Nullable<int> Creator { get; set; }
        public Nullable<System.DateTime> Modified { get; set; }
        public Nullable<int> Modifier { get; set; }
        public Nullable<int> CancelledByStaffID { get; set; }
    
        public virtual Staff BookedBy { get; set; }
        public virtual Staff CancelledBy { get; set; }
        public virtual Sess Sess { get; set; }
        public virtual Staff Staff { get; set; }
    }
}
