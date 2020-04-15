using ASP.NET_DesignStudio.Interfaces;
using ASP.NET_DesignStudio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.NET_DesignStudio.Repositories
{
    public class ExampleRepository : IRepository<Example>
    {
        DesignDbContext db;

        public ExampleRepository(DesignDbContext context)
        {
            this.db = context;
        }

        public void Create(Example item)
        {
            db.Examples.Add(item);
        }

        public void Delete(int id)
        {
            var example = db.Examples.Find(id);
            if (example != null)
            {
                db.Examples.Remove(example);
            }
        }

        public Example Get(int id)
        {
            return db.Examples.Find(id);
        }

        public IEnumerable<Example> GetAll()
        {
            return db.Examples;
        }

        public void Update(Example item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}