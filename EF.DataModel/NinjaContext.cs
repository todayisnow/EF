﻿using EF.Classes;
using System.Data.Entity;

namespace EF.DataModel
{
    public class NinjaContext:DbContext
    {
        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Clan> Clans { get; set; }
        public DbSet<NinjaEquipment> Equipment { get; set; }
    }
}
