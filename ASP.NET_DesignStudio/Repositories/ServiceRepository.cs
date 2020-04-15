using ASP.NET_DesignStudio.Interfaces;
using ASP.NET_DesignStudio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.NET_DesignStudio.Repositories
{
    public class ServiceRepository : IRepository<Service>
    {
        DesignDbContext db;

        public ServiceRepository(DesignDbContext context)
        {
            this.db = context;
        }

        public void Create(Service item)
        {
            db.Services.Add(item);
        }

        public void Delete(int id)
        {
            var service = db.Services.Find(id);
            if (service != null)
            {
                db.Services.Remove(service);
            }
        }

        public Service Get(int id)
        {
            var service = db.Services.Find(id);
            return service;
        }

        public IEnumerable<Service> GetAll()
        {
            return db.Services;
        }

        public void Update(Service item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}