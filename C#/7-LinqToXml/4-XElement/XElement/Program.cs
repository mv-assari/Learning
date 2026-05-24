

using System.Xml.Linq;

XElement element = new XElement("Contact",
                    new XElement("Contact",
                     new XAttribute("Id",1000),
                     new XElement("Name","vahid"),
                     new XElement("Phonenumber",09101396065)),
                    new XElement("Contact",
                     new XAttribute("Id",1002),
                     new XElement("Name","fatemeh"),
                     new XElement("Phonenumber",09308414411)));

//element.Add(new XElement("Contact", "Test"));

element.Add(new XElement("Contact",
                new XElement("Name","maman"),
                new XElement("Phoanenumber",091255333578)));

//foreach (var item in element.Nodes())
//{
//    Console.WriteLine(item);
//}

//foreach (var item in element.Elements())
//{
//    //item. دراینجا دسترسی های خیلی زیادی در مورد المنت داریم 
//    Console.WriteLine(item);
//}

var findbyAttribute = element
    .Elements()
    .Where(e => e.Attribute("Id").Value == "1000")
    .FirstOrDefault();

Console.WriteLine(findbyAttribute);

var findbyValue = element.Elements()
                .Where(e => e.Element("Name").Value == "vahid")
                .FirstOrDefault();

Console.WriteLine(findbyValue);

element.Elements()
       .Where(e => e.Element("Name").Value == "vahid")
       .FirstOrDefault(n=>n.Name=="Name").Value="vahidddd";

element.Elements()
       .Where(e => e.Attribute("Id").Value == "1000")
       .Remove();

Console.WriteLine(element);

//Console.WriteLine(element);

Console.ReadLine();