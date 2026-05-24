using System.Xml.Linq;

XElement element = new XElement("Contacts"
                    , new XComment("this is test comment")
                    , new XElement("Contact"
                    , new XAttribute("Id", 1001)
                    , new XComment("comment text")
                    , new XAttribute("City", "Tehran")));


var comments = element.DescendantNodes().OfType<XComment>().ToList();

foreach (var item in comments)
{
    Console.WriteLine(item);
}

element.DescendantNodes().OfType<XComment>().Where(c => c.Value.Contains("test")).FirstOrDefault().Value = "this is test2 comment";

element.DescendantNodes().OfType<XComment>().Where(c => c.Value.Contains("test")).Remove();


Console.WriteLine(element);


Console.ReadLine();
