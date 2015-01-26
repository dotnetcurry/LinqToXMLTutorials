using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace LINQToXMLPart2
{
    class Program
    {
        // LINQ To XML Examples brought to you by DotNetCurry.com
        // Check the article here http://www.dotnetcurry.com/ShowArticle.aspx?ID=564

        static void Main(string[] args)
        {
            // 1. Create an XML Document with Namespace/Comments
            //XNamespace empNM = "urn:lst-emp:emp";

            //XDocument xDoc = new XDocument(
            //            new XDeclaration("1.0", "UTF-16", null),
            //            new XElement(empNM + "Employees",
            //                new XElement("Employee",
            //                    new XComment("Only 3 elements for demo purposes"),
            //                    new XElement("EmpId", "5"),
            //                    new XElement("Name", "Kimmy"),
            //                    new XElement("Sex", "Female")
            //                    )));

            //StringWriter sw = new StringWriter();
            //xDoc.Save(sw);
            //Console.WriteLine(sw);

            // 2. Save the XML Document to a XMLWriter or to the disk            
            //XNamespace empNM = "urn:lst-emp:emp";

            //XDocument xDoc = new XDocument(
            //            new XDeclaration("1.0", "UTF-16", null),
            //            new XElement(empNM + "Employees",
            //                new XElement("Employee",
            //                    new XComment("Only 3 elements for demo purposes"),
            //                    new XElement("EmpId", "5"),
            //                    new XElement("Name", "Kimmy"),
            //                    new XElement("Sex", "Female")
            //                    )));

            //StringWriter sw = new StringWriter();
            //XmlWriter xWrite = XmlWriter.Create(sw);
            //xDoc.Save(xWrite);
            //xWrite.Close();

            //// Save to Disk
            //xDoc.Save("C:\\Something.xml");
            //Console.WriteLine("Saved");

            // 3. Load an XML Document using XML Reader           
            //XmlReader xRead = XmlReader.Create(@"..\\..\\Employees.xml");
            //XElement xEle = XElement.Load(xRead);
            //Console.WriteLine(xEle);
            //xRead.Close();

            // 4. Find the second Employee Element
            //// Using XElement
            //Console.WriteLine("Using XElement");
            //XElement xEle = XElement.Load("..\\..\\Employees.xml");
            //var emp = xEle.Descendants("Employee").ElementAt(1);
            //Console.WriteLine(emp);

            //Console.WriteLine("------------");

            ////// Using XDocument
            //Console.WriteLine("Using XDocument");
            //XDocument xDoc = XDocument.Load("..\\..\\Employees.xml");
            //var emp1 = xDoc.Descendants("Employee").ElementAt(2);
            //Console.WriteLine(emp);

            // 5. List the First 2 Employees
            //XElement xEle = XElement.Load("..\\..\\Employees.xml");
            //var emps = xEle.Descendants("Employee").Take(2);
            //foreach (var emp in emps)
            //    Console.WriteLine(emp);

            // 6. List the 2nd and 3rd Employees
            //XElement xEle = XElement.Load("..\\..\\Employees.xml");
            //var emps = xEle.Descendants("Employee").Skip(1).Take(2);
            //foreach (var emp in emps)
            //    Console.WriteLine(emp);

             //7. List the Last 2 Employees
            //XElement xEle = XElement.Load("..\\..\\Employees.xml");
            //var emps = xEle.Descendants("Employee").Reverse().Take(2);
            //foreach (var emp in emps)
            //Console.WriteLine(emp.Element("EmpId") + "" + emp.Element("Name"));

            // Display Only Values
            //XElement xEle = XElement.Load("..\\..\\Employees.xml");
            //var emps = xEle.Descendants("Employee").Reverse().Take(2);
            //foreach (var emp in emps)
            //Console.WriteLine(emp.Element("EmpId").Value + ". " + emp.Element("Name").Value);

             //To display the results in order i.e display
             //Employee 3 and then 4 use Reverse().Take(2).Reverse();
            //XElement xEle = XElement.Load("..\\..\\Employees.xml");
            //var emps = xEle.Descendants("Employee").Reverse().Take(2).Reverse();
            //foreach (var emp in emps)
            //    Console.WriteLine(emp.Element("EmpId").Value + ". " + emp.Element("Name").Value);


            // 8. Find the number of Employees living in the state CA
            //XElement xelement = XElement.Load("..\\..\\Employees.xml");
            //var stCnt = from address in xelement.Elements("Employee")
            //            where (string)address.Element("Address").Element("State") == "CA"
            //            select address;
            //Console.WriteLine("No of Employees living in CA State are {0}", stCnt.Count());

            // 

            Console.ReadLine();

        }
    }
}
