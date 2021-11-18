using Microsoft.EntityFrameworkCore;
using System;

namespace ClassLibrary1
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {


           
        }

        public virtual DbSet<MySet> MySet { get; set; }

        public void DoEvilStuff()
        {
            using (var con = Database.GetDbConnection())
            {
                con.Open();
                foreach (var entityType in Model.GetEntityTypes())
                {
                    var xx = entityType.ClrType.Name;
                }

            }
        }
    }

    public class MySet
    {

    }
}
