using SignalR.DAL.Abstract;
using SignalR.DAL.Concrete;
using SignalR.DAL.Repositories;
using SignalR.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DAL.EntityFramework
{
    public class EFDiscountDAL : GenericRepository<Discount>, IDiscountDAL
    {
        public EFDiscountDAL(SignalRContext context) : base(context)
        {
        }
    }
}
