SortedSet<int> st = new SortedSet<int>();

//مقادیر تکراری قبول نمیکنه
st.Add(1);
st.Add(3);
st.Add(2);
st.Add(4);
st.Add(6);
st.Add(5);
st.Add(8);
st.Add(7);

foreach (int i in st)
{
    Console.WriteLine(i);
}

st.Remove(1);
st.RemoveWhere(x => x == 2);
st.Clear();

Console.ReadLine();