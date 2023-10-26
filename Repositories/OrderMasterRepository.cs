using GRT_ASSIIGNMENT.Data;
using GRT_ASSIIGNMENT.Models;
using Microsoft.EntityFrameworkCore;

namespace GRT_ASSIIGNMENT.Repositories
{
    public class OrderMasterRepository : IOrderMasterRepository
    {
        
        private readonly ApplicationDbContext _context;

        public OrderMasterRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public OrderMaster Add(OrderMaster orderMaster)
        {
            throw new NotImplementedException();
        }

        public OrderMaster Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderMaster> GetAll()
        {
            return  _context.OrderMasters.Include(x => x.Customer).ToList();
        }

        public OrderMaster GetById(long Id)
        {
            ////get product from order details
            //var orderDetails = (from master in _context.Set<OrderMaster>()
            //                         join detail in _context.Set<OrderDetail>()
            //                         on master.OrderMasterId equals detail.OrderMasterId
            //                         join product in _context.Set<Product>()
            //                         on detail.ProductId equals product.ProductId
            //                         where master.OrderMasterId == Id

            //                         select new
            //                         {
            //                             master.OrderMasterId,
            //                             detail.OrderDetailId,
            //                             detail.ProductId,
            //                             detail.Quantity,
            //                             detail.ProductPrice,
            //                             product.ProductName
            //                         }).ToListAsync();

            //// get order master
            //var orderMaster = (from a in _context.Set<OrderMaster>()
            //                        where a.OrderMasterId == Id

            //                        select new
            //                        {
            //                            a.OrderMasterId,
            //                            a.OrderNumber,
            //                            a.CustomerId,
            //                            a.PMethod,
            //                            a.GTotal,
            //                            deletedOrderItemIds = "",
            //                            orderDetails = orderDetails
            //                        }).FirstOrDefaultAsync();

            //if (orderMaster == null)
            //{
            //    return null;
            //}

            //return orderMaster;
            throw new NotImplementedException();
        }

        public OrderMaster Update(OrderMaster orderMaster)
        {
            throw new NotImplementedException();
        }
    }
}
