using System.Collections;

var bits = new BitArray(3);

bits.Set(0, true);
bits.Set(1, true);
bits.Set(2, true);

Console.WriteLine(bits.Get(0));
bits[2] = false;
bits.SetAll(true);