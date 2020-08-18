using Dapper;
using DataLibrary.Db;
using DataLibrary.Models;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DataLibrary.Data
{
    public class OrderData : IOrderData
    {
        private readonly IDataAccess _dataAccess;
        private readonly ConnectionStringData _connectionString;
        public OrderData(IDataAccess dataAccess, ConnectionStringData connectionString)
        {
            _dataAccess = dataAccess;
            _connectionString = connectionString;
        }

        public async Task<int> CreateOrder(OrderModel order)
        {
            DynamicParameters p = new DynamicParameters();
            p.Add("OrderName", order.OrderName);
            p.Add("OrderDate", order.OrderDate);
            p.Add("FoodId", order.FoodId);
            p.Add("Quantity", order.Quantity);
            p.Add("Total", order.Total);
            p.Add("Id", DbType.Int32, direction: ParameterDirection.Output);
            await _dataAccess.SaveData("dbo.spOrder_Insert", p, _connectionString.SqlConnectionName);
            return p.Get<int>("Id");
        }

        public async Task<int> UpdateOrderName(int OrderId, string OrderName)
        {
            return await _dataAccess.SaveData("dbo.spOrder_UpdateName", new { Id = OrderId, OrderName = OrderName }, _connectionString.SqlConnectionName);
        }

        public Task<int> DeleteOrder(int OrderId)
        {
            return _dataAccess.SaveData("dbo.spOrder_Delete", new { Id = OrderId }, _connectionString.SqlConnectionName);

        }

        public async Task<OrderModel> GetOrderById(int OrderId)
        {
            var res = await _dataAccess.LoadData<OrderModel, dynamic>("dbo.spGetOrder_ByID", new { Id = OrderId }, _connectionString.SqlConnectionName);
            return res.FirstOrDefault();
        }
    }
}
