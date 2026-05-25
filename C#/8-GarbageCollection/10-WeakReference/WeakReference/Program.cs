



//WeakReference weak = new WeakReference("my data",false);

//Console.WriteLine(weak.IsAlive);
//Console.WriteLine(weak.Target);

using WeakReference;

Contact contact = new Contact();

var data1 = contact.GetContacts();
var data2 = contact.GetContacts();
var data3 = contact.GetContacts();

Console.ReadLine();