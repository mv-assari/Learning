
ResultDto<int> result1=new ResultDto<int>();
ResultDto<string> result2=new ResultDto<string>();
ResultDto<Test> result3=new ResultDto<Test>();


public class ResultDto<T> where T:Itest
{
    public bool? Secced { get; set; } = null;
    public string Message { get; set; } = null;
    public T? Data { get; set; } = default;//مقدار پیشفرض هر نوعی که از ورودی دریافت میکنی
}

//1-struct 2-class 3-implement interface 4-inheritance class 5-new() --> null counstructor 6-T1,T2 --> T1:T2 

public interface Itest
{

}

public class Test : Itest
{

}


//Inheritance
public class BaseClass<T> { }
public class DClass<T>:BaseClass<T> { }


//Static
public class Utility<T>
{
    public static T Value { get; set; }
}