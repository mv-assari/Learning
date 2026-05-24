using NewLinqMethods;

List<Product> products = new List<Product>()
{
    new Product(1,"p1",10000),
    new Product(2,"p2",20000),
    new Product(3,"p3",30000),
    new Product(4,"p4",40000),
    new Product(5,"p5",50000),
    new Product(6,"p6",60000),
    new Product(7,"p7",70000),
    new Product(8,"p8",80000),
    new Product(9,"p9",90000),
    new Product(10,"p10",100000)
};

var chunk = products.Chunk(6); //برای دسته بندی لیست ها به لیست های کوچک

//maxby and minby

var maxby=products.MaxBy(x => x.Price);
var minby=products.MinBy(x => x.Price);

// default value
//firstordefault lastordefault singleordefault elementatordefault

var firstordefault=products.FirstOrDefault(p=>p.Price<1000,new Product(1,"test",1000)/*default value*/);

//take

int[] array = { 100, 200, 300, 400, 500 };

var list = array.Take(2..);
var list2 = array.Take(..2);
var list3 = array.Take(2..4);
var list4 = array.Take(^2..); // از اخر لیست دوتا بده


//zip

int[] Ids = { 1, 2, 3, 4, 5, 6, 7, 8 };
int[] Age = { 21, 22, 23, 24, 25, 26, 27, 28 };
string[] Name = { "n1", "n2", "n3", "n4", "n5", "n6", "n7", "n8" };

IEnumerable<(int Id, string Name, int Age)> zipResult = Ids.Zip(Name, Age);

foreach (var item in zipResult)
{
    Console.WriteLine($"Id:{item.Id} Name:{item.Name} Age:{item.Age}");
}

Console.ReadLine();

//TryGetNonEnumeratedCount

var result = products.TryGetNonEnumeratedCount(out int count);