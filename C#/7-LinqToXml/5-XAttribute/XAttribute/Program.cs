using System.Xml.Linq;

XElement element = new XElement("Contacts", new XElement("Contact", new XAttribute("Id", 1001), new XAttribute("City", "Tehran")));


foreach (var item in element.Elements().FirstOrDefault().Attributes())
{
    Console.WriteLine(item);
}

element.Elements().FirstOrDefault().Add(new XAttribute("Country", "Iran"));


element.Elements().FirstOrDefault().Attribute("Id").Remove();

element.Elements().FirstOrDefault().Attribute("City").SetValue("Qom");

Console.WriteLine(element);


Console.ReadLine();