using System.Xml.Linq;

XDocument doc1 = new XDocument();

doc1.Add(new XElement("Curses", "test"));
Console.WriteLine(doc1);
//-------------------------------

XDocument doc2 = XDocument.Load(@"F:\Learning\Learning\C#\7-LinqToXml\3-XDocument\XDocument\Product.xml");
Console.WriteLine(doc2);

//-------------------------------

string xmldata = @"<product id=""101"" category=""electronics"">
<name>لپ‌تاپ ایسوس</name>
<brand>Asus</brand>
<price currency=""IRR"">45,000,000</price>
<inStock>true</inStock>
<specs>
<ram>16GB</ram>
<storage>512GB SSD</storage>
</specs>
</product>";

XDocument doc3 = XDocument.Parse(xmldata);
Console.WriteLine(doc3);
doc3.Save("xmlfile.xml");



Console.ReadLine();