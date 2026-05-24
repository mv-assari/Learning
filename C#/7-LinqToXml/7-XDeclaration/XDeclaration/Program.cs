using System.Xml.Linq;


XDeclaration declaration = new XDeclaration("1.0", "UTF-16", "no");
XDocument document = new XDocument(declaration);
XElement element = new XElement("Contacts"
                    , new XComment("this is test comment")
                    , new XElement("Contact"
                    , new XAttribute("Id", 1001)
                    , new XComment("comment text")
                    , new XAttribute("City", "Tehran")));

document.Add(element);

//Console.WriteLine(document);

document.Save(@"D:\file\docc.xml");



//Console.ReadLine();