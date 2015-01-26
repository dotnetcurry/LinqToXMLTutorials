using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;

namespace LINQToXMLPart3
{
    class Program
    {
        static void Main(string[] args)
        {
    //// 1. Add a new XElement at runtime
    //XElement xEle = XElement.Load("..\\..\\Employees.xml");
    //xEle.Add(new XElement("Employee",
    //    new XElement("EmpId", 5),
    //    new XElement("Name", "George")));

    //Console.Write(xEle);

    //// 2. Add a new XElement as the FirstChild
    //XElement xEle = XElement.Load("..\\..\\Employees.xml");
    //xEle.AddFirst(new XElement("Employee",
    //    new XElement("EmpId", 5),
    //    new XElement("Name", "George")));

    //Console.Write(xEle);

    //// 3. Add an Attribute to an Element
    //XElement xEle = XElement.Load("..\\..\\Employees.xml");
    //xEle.Add(new XElement("Employee",
    //    new XElement("EmpId", 5),
    //    new XElement("Phone", "423-555-4224", new XAttribute("Type", "Home"))));

    //Console.Write(xEle);

    //// 4. Replace the content of an Element
    //XElement xEle = XElement.Load("..\\..\\Employees.xml");
    //var countries = xEle.Elements("Employee").Elements("Address").Elements("Country").ToList();
    //foreach (XElement cEle in countries)
    //    cEle.ReplaceNodes("United States Of America");

    //Console.Write(xEle);

    //// 5. Remove Attribute from all the Elements
    //XElement xEle = XElement.Load("..\\..\\Employees.xml");
    //var phone = xEle.Elements("Employee").Elements("Phone").ToList();
    //foreach (XElement pEle in phone)
    //    pEle.RemoveAttributes();

    //Console.Write(xEle);

    //// 6. Delete an Element Based on a Condition
    //XElement xEle = XElement.Load("..\\..\\Employees.xml");
    //var addr = xEle.Elements("Employee").ToList();
    //foreach (XElement addEle in addr)
    //    addEle.SetElementValue("Address", null);

    //Console.Write(xEle);

    //// 7. Delete 'n' number of Elements            
    //XElement xEle = XElement.Load("..\\..\\Employees.xml");
    //var emps = xEle.Descendants("Employee");
    //emps.Reverse().Take(2).Remove();

    //Console.Write(xEle);


    //// 8. Persists changes to the XML
    //XElement xEle = XElement.Load("..\\..\\Employees.xml");
    //xEle.Add(new XElement("Employee",
    //new XElement("EmpId", 5),
    //new XElement("Name", "George"),
    //new XElement("Sex", "Male"),
    //new XElement("Phone", "423-555-4224", new XAttribute("Type", "Home")),
    //new XElement("Phone", "424-555-0545", new XAttribute("Type", "Work")),
    //new XElement("Address",
    //    new XElement("Street", "Fred Park, East Bay"),
    //    new XElement("City", "Acampo"),
    //    new XElement("State", "CA"),
    //    new XElement("Zip", "95220"),
    //    new XElement("Country", "USA"))));

    //xEle.Save("..\\..\\Employees.xml");
    //Console.WriteLine(xEle);

    //Console.ReadLine();           
        }
    }
}
