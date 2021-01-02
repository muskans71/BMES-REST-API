using BMES_REST_API.Messages.Request;
using BMES_REST_API.Messages.Request.Order;
using BMES_REST_API.Messages.Response.Order;
using BmesRestApi.Repositories;

namespace BmesRestApi.Services.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public GetOrderResponse GetOrder(GetOrderRequest getOrderRequest)
        {
            return new GetOrderResponse();
        }

        public FetchOrderResponse GetOrders(FetchOrderRequest fetchOrdersRequest)
        {
            return new FetchOrderResponse();
        }
    }
}
