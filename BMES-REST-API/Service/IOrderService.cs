using BMES_REST_API.Messages.Request;
using BMES_REST_API.Messages.Request.Order;
using BMES_REST_API.Messages.Response.Order;

namespace BmesRestApi.Services
{
    public interface IOrderService
    {
        public GetOrderResponse GetOrder(GetOrderRequest getOrderRequest);
        public FetchOrderResponse GetOrders(FetchOrderRequest fetchOrdersRequest);
    }
}
