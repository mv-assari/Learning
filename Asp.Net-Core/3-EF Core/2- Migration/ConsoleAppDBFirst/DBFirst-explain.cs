/*
در این بخش به نحوه انتقال جداول به برنامه اشاره شده است
برای اینکار باید پکیج های 
EFCore and sqlserver and tools
در پروژه نصب کنیم. حالا در قسمت 
pakage manager console 
دستور زیر را وارد میکنیم

Scaffold-DbContext "Server=servername; Initial Catalog=databasename; Integrated Security=true"
Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

حالا توسط خود پکیج هایی که در برنامه نصب کردیم و پوشه ای که براش مشخص کردیم شروع به ساخت مدل های دیتابیس میکند

*/
