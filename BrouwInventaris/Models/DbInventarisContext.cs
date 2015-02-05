﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace BrouwInventaris.Models
{
    class DbInventarisContext : DbContext
    {
        public DbInventarisContext()  : base("Model1")// Later veranderen kijk in web.config
        {
            Database.SetInitializer<DbInventarisContext>(new DropCreateDatabaseAlways<DbInventarisContext>());
        //    Database.SetInitializer<DbInventarisContext>(new CreateDatabaseIfNotExists<DbInventarisContext>());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Brouwerij> Brouwerijen { get; set; }
        public DbSet<Aankoop> Aankopen { get; set; }
        public DbSet<Artikel> Artikels{ get; set; }
        public DbSet<Hop> Hoppen { get; set; }
        public DbSet<Mout> Mouten { get; set; }
        
    }
}
