using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CustomViewEngine.Models
{
    public class CustomViewEngineContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CustomViewEngineContext() : base("name=CustomViewEngineContext")
        {
        }

        public System.Data.Entity.DbSet<CustomViewEngine.Core.DataForm> DataForms { get; set; }

        public System.Data.Entity.DbSet<CustomViewEngine.Core.DataField> DataFields { get; set; }
    }
}
