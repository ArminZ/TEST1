//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirNavigationRaceLive
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_Pilot
    {
        public t_Pilot()
        {
            this.t_Team = new HashSet<t_Team>();
            this.t_Team1 = new HashSet<t_Team>();
        }
    
        public int ID { get; set; }
        public string LastName { get; set; }
        public string SureName { get; set; }
        public Nullable<int> ID_Picture { get; set; }
        public int ID_CompetitionSet { get; set; }
    
        public virtual t_CompetitionSet t_CompetitionSet { get; set; }
        public virtual t_Picture t_Picture { get; set; }
        public virtual ICollection<t_Team> t_Team { get; set; }
        public virtual ICollection<t_Team> t_Team1 { get; set; }
    }
}
