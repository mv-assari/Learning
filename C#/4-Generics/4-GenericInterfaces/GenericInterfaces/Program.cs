
Test test = new Test();

test.Add(2);
test.Add(3);
test.Add(4);
test.Add(5);
test.Add(6);
test.Add(7);

var a=test.GetList();


Console.ReadLine();

public interface ImyInterface<T>
{
    List<T> GetList();
}

public class Test:ImyInterface<int>
{
    List<int> _list=new List<int>();

    public void Add(int item)
    {
        _list.Add(item);
    }

    public List<int> GetList()
    {
        return _list;
    }
}


public class MyClass<T> : ImyInterface<T>
{
    List<T> _list=new List<T>();

    public void Add(T item)
    {
        _list.Add(item);
    }


    public List<T> GetList()
    {
        return _list;
    }
}