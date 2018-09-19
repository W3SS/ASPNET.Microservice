using ASPNET.Bootcamp.Common.Interfaces;
using ASPNET.Bootcamp.DataAccess.Context;
using ASPNET.Bootcamp.DataAccess.Models;
using ASPNET.Bootcamp.DataAccess.Params;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNET.Bootcamp.BussinessLogic.Services
{
    public class SupplierService : ISupplierService
    {
        ApplicationDbContext db = new ApplicationDbContext();

        public void Delete(int? id)
        {
            var get = Get(id);
            get.Delete();
            db.SaveChanges();
        }

        public IEnumerable<Supplier> Get()
        {
            var get = db.Suppliers.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Supplier Get(int? id)
        {
            if(id == null)
            {
                Console.Write("Id is null");
            }
            var get = db.Suppliers.Find(id);
            if(get == null)
            {
                Console.Write("Data not found");
            }
            return get;
        }

        public void Insert(SupplierParam param)
        {
            var push = new Supplier(param.Name);
            db.Suppliers.Add(push);
            db.SaveChanges();
        }
        
        public void Update(int? id, SupplierParam param)
        {
            var get = Get(id);
            get.Update(param.Name);
            db.Entry(get).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
