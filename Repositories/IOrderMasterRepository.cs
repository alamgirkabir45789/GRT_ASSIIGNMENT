using GRT_ASSIIGNMENT.Models;

namespace GRT_ASSIIGNMENT.Repositories
{
    public interface IOrderMasterRepository
    {
        OrderMaster GetById(long Id);
        IEnumerable<OrderMaster> GetAll();

        OrderMaster Add(OrderMaster orderMaster);
        OrderMaster Update(OrderMaster orderMaster);
        OrderMaster Delete(int Id);
    }
}
