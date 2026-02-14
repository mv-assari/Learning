// به دو صورت میتوان دستورات را نوشت

// Query Syntax 
var result=from c in companies
where c.Name == "Lenovo"
select c ;

// Method Syntax
var result = companies.Where(p=>p.Name=="Lenovo");