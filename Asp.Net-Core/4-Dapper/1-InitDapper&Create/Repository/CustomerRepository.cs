using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICustomerRepository
    {
        public int Add(CustomerDto customer);
        public int Add(List<CustomerDto> customers);
        public int Delete(long id);
        public int Delete(List<long> Ids);
        public int Update(CustomerDto customer);
        public int Update(List<CustomerDto> customers);
        public List<CustomerDto> GetCustomers();
        public CustomerDto GetCustomer(long id);
    }

    //تجربه 
    //Microsoft.Data.SqlClient نصب کردم چون ورژن جدید هنوز استیبل نشده بود و سازگار با دپر نبود به خطا میخوردم که باید ورژن های قبلی رو نصب میکردم وقتی کتابخونه
    public class CustomerRepository:ICustomerRepository
    {
        private readonly string connectionString= @"Server=.;Initial Catalog=DapperDb;Integrated Security=true;TrustServerCertificate=True;";

        public int Add(CustomerDto customer)
        {
            string Sql = "INSERT INTO CUSTOMER (FirstName,LastName) VALUES (@FirstName,@LastName)";
            var connection = new SqlConnection(connectionString);//SqlConnection نیاز به نصب کتابخونه داره
            var result= connection.Execute(Sql,new {FirstName=customer.FirstName,LastName=customer.LastName});// چون از دپر استفاده میکنیم نیاز به نصب کتابخونه دپر داره
            return result;
        }

        public int Add(List<CustomerDto> customers)
        {
            string Sql = "INSERT INTO CUSTOMER (FirstName,LastName) VALUES (@FirstName,@LastName)";
            var connection = new SqlConnection(connectionString);
            var result = connection.Execute(Sql, customers);
            return result;
        }

        public int Delete(long id)
        {
            string Sql = "DELETE FROM CUSTOMER WHERE ID=@Id";
            var connection=new SqlConnection(connectionString);
            var result=connection.Execute(Sql,new {Id=id});
            return result;
        }

        public int Delete(List<long> ids)
        {
            string Sql = "DELETE FORM CUSTOMER WHERE ID=@Id";
            var connection=new SqlConnection(connectionString);
            var resutl=connection.Execute(Sql, ids);
            return resutl;
        }

        public CustomerDto GetCustomer(long id)
        {
            string Sql = "SELECT * FROM CUSTOMER WHERE ID=@Id";
            var connection = new SqlConnection(connectionString); //SqlConnection نیاز به نصب کتابخونه داره
            var result = connection.QueryFirstOrDefault<CustomerDto>(Sql, new { ID=id }); // چون از دپر استفاده میکنیم نیاز به نصب کتابخونه دپر داره
            return result;
        }

        public List<CustomerDto> GetCustomers()
        {
            string Sql = "SELECT Id,FirstName,LastName FROM CUSTOMER";
            var connection = new SqlConnection(connectionString);
            var result = connection.Query<CustomerDto>(Sql);
            return result.ToList();
        }

        public int Update(CustomerDto customer)
        {
            string Sql = "UPDATE CUSTOMER SET FirstName=@FirstName , LastName=@LastName WHERE ID=@Id";
            var connection = new SqlConnection(connectionString);
            var result = connection.Execute(Sql,customer);
            return result;
        }

        public int Update(List<CustomerDto> customers)
        {
            string Sql = "UPDATE CUSTOMER SET FirstName=@FirstName , LastName=@LastName WHERE Id=@Id";
            var connection = new SqlConnection(connectionString);
            var result= connection.Execute(Sql,customers);
            return result;
        }
    }

    public class CustomerDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
