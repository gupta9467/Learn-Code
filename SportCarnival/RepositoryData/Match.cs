//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportCarnival.RepositoryData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Match
    {
        public int matchId { get; set; }
        public System.DateTime date { get; set; }
        public int firstTeamId { get; set; }
        public int secondTeamId { get; set; }
        public int duration { get; set; }
    
        public virtual Team Team { get; set; }
        public virtual Team Team1 { get; set; }
    }
}
