int[] array1 = { 1, 2, 3, 4, 3 };
int[] array2 = { 2, 3, 4, 5 };

var except=array1.Except(array2);

var distinct = array1.Distinct();

var intersect=array1.Intersect(array2); //اشتراک

var concat=array1.Concat(array2); //اتصال دو لیست

var union=array1.Union(array2); //اجتماع بدون ایتم تکراری

