int number = 20;
Print(ref number);//ref
Console.WriteLine(number);

object a = 1;
int b=(int )a; //unboxing
object c = b;  //boxing

void Print(ref int n) //ref
{
    n++;
    Console.WriteLine(n);
}