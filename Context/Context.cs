using AspDotNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspDotNetMVC.Context
{
    public class AspDotNetMVCContext : DbContext
    {
        public AspDotNetMVCContext() : base("AspDotNetMVC")
        {

        }

        public System.Data.Entity.DbSet<AspDotNetMVC.Models.Citizien> Citiziens { get; set; }
    }
}