//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirNavigationRaceLive
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subscriber
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    
        public virtual Competition Competition { get; set; }
        public virtual Picture Picture { get; set; }
    }
}
