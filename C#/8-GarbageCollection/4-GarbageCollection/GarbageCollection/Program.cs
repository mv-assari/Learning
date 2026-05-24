Print();

void Print()
{
    string message = "test text"; //save to heap(soh)
    byte[] data=new byte[68000]; //save to heap(loh)
    Console.WriteLine(message);
}