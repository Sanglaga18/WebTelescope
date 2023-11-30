using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telescope.DataAccess.Data;
using Telescope.DataAccess.Repository.IRepository;
using Telescope.Models;

namespace Telescope.DataAccess.Repository
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private ApplicationDbContext _db;
        public OrderDetailRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(OrderDetail obj)
        {
            _db.OrderDetails.Update(obj);
        }
    }
}
