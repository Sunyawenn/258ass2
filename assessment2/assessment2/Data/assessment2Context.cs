﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace assessment2.Data
{
    public class assessment2Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public assessment2Context() : base("name=assessment2Context")
        {
        }
        public System.Data.Entity.DbSet<assessment2.Models.Product> Products { get; set; }
        public System.Data.Entity.DbSet<assessment2.Models.Category> Categories { get; set; }
    }
}
