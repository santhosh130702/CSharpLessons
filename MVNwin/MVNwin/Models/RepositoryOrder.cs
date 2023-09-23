using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MVNwin.Models
{
    public class RepositoryOrder
    {
        private readonly NorthwindContext _context;
        public int SelectedId { get; set; }
        public List<SelectListItem> OrderSelectView { get; set; }
        public RepositoryOrder() { }
        public RepositoryOrder(NorthwindContext context)
        {
            _context = context;
        }
        public Order FindOrderById(int id)
        {
            var order = _context.Orders.Find(id);
            return order;
        }
    public List<int> GetAllOrderId()

        {

            List<int> orderIds = new List<int>();

            foreach (var order in _context.Orders)

            {

                orderIds.Add(order.OrderId);

            }

            return orderIds;

        }
        public List<Order> Orders()
        {
            return _context.Orders.ToList();
        }
        public List<OrderDetail> FindOrderDetailByOrderId(int id)
        {
            ////    Order order = _context.Orders.Find(id);
            List<Order> orderWithOrderDetails =
                _context.Orders.Include(d => d.OrderDetails).ToList();
            Order order= orderWithOrderDetails.FirstOrDefault(x =>x.OrderId == id);
            return order.OrderDetails.ToList();
        }
    }
}
