using ASP.NET_DesignStudio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_DesignStudio.Repositories
{
    public class UnitOfWork : IDisposable
    {
        DesignDbContext db = new DesignDbContext();
        MasterRepository masterRepository;
        ServiceRepository serviceRepository;
        ExampleRepository exampleRepository;

        public MasterRepository Masters
        {
            get
            {
                if (masterRepository == null)
                    masterRepository = new MasterRepository(db);
                return masterRepository;
            }
        }

        public ServiceRepository Services
        {
            get
            {
                if (serviceRepository == null)
                    serviceRepository = new ServiceRepository(db);
                return serviceRepository;
            }
        }

        public ExampleRepository Examples
        {
            get
            {
                if (exampleRepository == null)
                    exampleRepository = new ExampleRepository(db);
                return exampleRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}