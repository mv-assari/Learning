using System.Collections;

var list =new ArrayList(); //چون نوع ما اینجا آبجکت قبول میکنه پس برای استفاده از اون باید عملیات باکسینگ و آنباکسینگ رو انجام بدیم که سربار داره

list.Add(123); //boxing
int n = (int)list[0]; //unboxing

var list2 = new List<int>(); //ولی در اینجا چون با استفاده از جنریک ها نوع دقیقا معلوم هست نیازی به موارد بالا نیست و سربار هم نداریم 
list2.Add(123);
int n2 = list2[0];

//پس در کل جنریک ها برای ما مزیت هایی دارند
//Performance
//Type Safety
//Reusability