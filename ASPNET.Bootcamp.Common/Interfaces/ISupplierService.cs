using ASPNET.Bootcamp.DataAccess.Models;
using ASPNET.Bootcamp.DataAccess.Params;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNET.Bootcamp.Common.Interfaces
{
    public interface ISupplierService
    {
        IEnumerable<Supplier> Get();
        Supplier Get(int? id);
        void Insert(SupplierParam param);
        void Update(int? id, SupplierParam param);
        void Delete(int? id);
    }
}
