using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryInDapper
{
    public class Ropository
    {


        private readonly string connectionString = @"server=.; initial catalog=DapperDb; integrated security=true;TrustServerCertificate=True;";

        public long Add(CustomerDto customer)
        {
            //OUTPUT INSERTED.Id
            //برای اینکه بفهمیم ای دی جدید تولید شده برای این ورودی جدید چی هست که ازون بتونیم استفاده کنیم
            string Sql = "INSERT INTO CUSTOMER (FirstName,LastName) OUTPUT INSERTED.Id VALUES (@FirstName,@LastName) ";
            var connection = new SqlConnection(connectionString);
            //ExecuteScalar 
            //از این تابع برای گرفتن خروجی ای دی تولید شده استفاده میکنیم
            var result = connection.ExecuteScalar<long>(Sql, customer);
            return result;
        }



        public List<Order> GetOrders()
        {
            string sql = "SELECT TOP 10 * FROM [ORDER] AS O INNER JOIN ORDERDETAIL AS OD ON O.ID=OD.ORDERID";
            var connection=new SqlConnection(connectionString);
            var orderDic = new Dictionary<long, Order>();

            var orderList = connection.Query<Order, OrderDetail, Order>(sql, (order, orderDetail) =>
            {
                Order entity;
                if(!orderDic.TryGetValue(order.Id, out entity))
                {
                    entity = order;
                    entity.OrderDetails = new List<OrderDetail>();
                    orderDic.Add(entity.Id, entity);
                }
                entity.OrderDetails.Add(orderDetail);
                return entity;
            },splitOn:"Id").Distinct().ToList();

            return orderList;
        }

        public List<Order> GetInvoice()
        {
            string sql = "SELECT * FROM [ORDER] AS O INNER JOIN INVOICE I ON O.ID=I.ID";

            var connection = new SqlConnection(connectionString);
            var orders = connection.Query<Order, Invoice, Order>(sql, (order, invoice) =>
            {
                order.Invoice = invoice;
                return order;
            },splitOn:"Id").Distinct().ToList();
            return orders;
        }

        public void QueryMultiple(out List<Order> a,out List<Invoice> b)
        {
            string sql = "SELECT * FROM [ORDER];SELECT * FROM Invoice;";//همزمان چند کوئری میتوان اجرا کرد و خروجی گرفت
            var connection = new SqlConnection(connectionString);
            var result = connection.QueryMultiple(sql);

            var orders=result.Read<Order>().ToList();
            var invoice = result.Read<Invoice>().ToList();
            a = orders;
            b = invoice;
        }

        public void Queries()
        {
            string sql = "SELECT * FROM [ORDER]";
            var connection = new SqlConnection(connectionString);
            var result1= connection.QueryFirst<Order>(sql); //این متدها همه در سمت کلاینت اجرا میشه و تمام داده را از دیتابیس میگیره
            var result2= connection.QueryFirstOrDefault<Order>(sql);
            var result3= connection.QuerySingle<Order>(sql);
            var result4= connection.QuerySingleOrDefault<Order>(sql);
        }

        public List<Order> RunSp()
        {
            string sql = "SELECTORDERS";
            var connection = new SqlConnection(connectionString);
            var result = connection.Query<Order>(sql,commandType:CommandType.StoredProcedure);

            return result.ToList();
        }
        
    }

    

    public class Invoice
    {
        public long Id { get; set; }
        public long Price { get; set; }
    }

    public class Order
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public Invoice Invoice { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }

    public class OrderDetail
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public string ProductName { get; set; }
    }

    public class CustomerDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
