using ASPNET.Bootcamp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNET.Bootcamp.DataAccess.Models
{
    public class Supplier : BaseModel
    {
        public string Name { get; set; }

        public Supplier() { }

        public Supplier(string name)
        {
            this.Name = name;
            this.CreateDate = DateTimeOffset.UtcNow.LocalDateTime;
        }

        public virtual void Update(string name)
        {
            this.Name = name;
            this.UpdateDate = DateTimeOffset.UtcNow.LocalDateTime;
        }

        public virtual void Delete()
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.UtcNow.LocalDateTime;
        }
    }
}
