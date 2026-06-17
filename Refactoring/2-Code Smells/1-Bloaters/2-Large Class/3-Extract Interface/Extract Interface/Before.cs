using System;

namespace Extract_Interface
{

    public class UserService
    {
        public void RegisterUser(string name, string email) { /* ... */ }
        public void DeleteUser(int id) { /* ... */ }
        public void LogActivity(string message) { /* ... */ }
        public void SendNotification(string to, string text) { /* ... */ }
        public string ExportData(string format) { /* ... */ }
    }

    public class ProductService
    {
        public void AddProduct(string name, decimal price) { /* ... */ }
        public void RemoveProduct(int id) { /* ... */ }
        public void LogActivity(string message) { /* ... */ }
        public void SendNotification(string to, string text) { /* ... */ }
        public string ExportData(string format) { /* ... */ }
    }

    public class ReportService
    {
        public void GenerateReport() { /* ... */ }
        public void LogActivity(string message) { /* ... */ }
        public void SendNotification(string to, string text) { /* ... */ }
        public string ExportData(string format) { /* ... */ }
        public void ScheduleReport(DateTime date) { /* ... */ }
    }
}
