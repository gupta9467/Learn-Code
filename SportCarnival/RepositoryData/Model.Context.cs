﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LearnCodeEntities : DbContext
    {
        public LearnCodeEntities()
            : base("name=LearnCodeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<GameType> GameTypes { get; set; }
        public virtual DbSet<Match> Matches { get; set; }
        public virtual DbSet<Occasion> Occasions { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Team_Player> Team_Player { get; set; }
    }
}
