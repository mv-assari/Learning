public interface IEnumerable<out T> : IEnumerable //حداقل امکانات مجموعه رو ارائه میده
{
    IEnumerator<T> GetEnumerator();
}

public interface ICollection<T> : IEnumerable<T>, IEnumerable //امکانات بیشتری ارائه میده
{
    int Count { get; }  
    bool IsReadOnly { get; }

    void Add(T item);
    void Clear();
    bool Contains(T item);
    void CopyTo(T[] array, int arrayIndex);
    bool Remove(T item);
}

public interface IList<T> : ICollection<T>, IEnumerable<T>, IEnumerable // علاوه بر امکانات کالکشن ها امکانات بیشتری ارائه میده
{
    T this[int index] { get; set; }

    int IndexOf(T item);
    void Insert(int index, T item);
    void RemoveAt(int index);
}

public interface IReadOnlyCollection<out T> : IEnumerable<T>, IEnumerable //فقط قابلیت خواندن و چرخیدن روی مجموعه هست
{
    int Count { get; }
}

public interface IReadOnlyList<out T> : IEnumerable<T>, IEnumerable, IReadOnlyCollection<T> //فقط قابلیت خواندن و چرخیدن روی مجموعه هست
{
    T this[int index] { get; }
}

Product Product = new Product(); //میتونیم براساس نیاز از هرکدوم استفاده کنیم
Product.ICollection.;
Product.IList;
Product.IReadOnlyCollection.;
Product.IReadOnlyList.;


public class Product
{
    public ICollection<Comment> ICollection { get; set; }// هر کدام ازاینها براساس نیازهای ما استفاده میشه و همینطور موارد زیر
    public IList<Comment> IList { get; set; }
    public IReadOnlyCollection<Comment> IReadOnlyCollection { get; set; }
    public IReadOnlyList<Comment> IReadOnlyList { get; set; }
}

public class Comment
{

}