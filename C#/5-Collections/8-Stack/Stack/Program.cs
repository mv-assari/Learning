using System.Collections;

Stack<int> st=new Stack<int>();

st.Push(0);
st.Push(1);
st.Push(2);
st.Push(3);
st.Push(4);

Console.WriteLine(st.Peek());
Console.WriteLine(st.Count);
Console.WriteLine(st.Pop());

st.Contains(0);
st.Clear();

//nonGeneric

Stack ng=new Stack();
//we can use object to input data