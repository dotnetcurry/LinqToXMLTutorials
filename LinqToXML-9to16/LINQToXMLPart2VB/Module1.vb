Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Xml
Imports System.IO
Imports System.Xml.Linq

Module Module1

    Sub Main()
        'LINQ To XML Examples brought to you by DotNetCurry.com
        'Check the article here http://www.dotnetcurry.com/ShowArticle.aspx?ID=564

        ' 1. Create an XML Document with Namespace/Comments
        'Dim empNM As XNamespace = "urn:lst-emp:emp"

        'Dim xDoc As New XDocument(New XDeclaration("1.0", "UTF-16", Nothing), _
        '            New XElement(empNM + "Employees", _
        '            New XElement("Employee", _
        '            New XComment("Only 3 elements for demo purposes"), _
        '            New XElement("EmpId", "5"), _
        '            New XElement("Name", "Kimmy"), _
        '            New XElement("Sex", "Female"))))

        'Dim sw As New StringWriter()
        'xDoc.Save(sw)
        'Console.WriteLine(sw)

        ' 2.Save the XML Document to a XMLWriter or to the disk    
        'Dim empNM As XNamespace = "urn:lst-emp:emp"

        'Dim xDoc As New XDocument(New XDeclaration("1.0", "UTF-16", Nothing), _
        'New XElement(empNM + "Employees", _
        'New XElement("Employee", _
        'New XComment("Only 3 elements for demo purposes"), _
        'New XElement("EmpId", "5"), _
        'New XElement("Name", "Kimmy"), _
        'New XElement("Sex", "Female"))))

        'Dim sw As New StringWriter()
        'Dim xWrite As XmlWriter = XmlWriter.Create(sw)
        'xDoc.Save(xWrite)
        'xWrite.Close()

        '' Save to Disk
        'xDoc.Save("C:\Something.xml")
        'Console.WriteLine("Saved")

        ' 3. Load an XML Document using XML Reader
        'Dim xRead As XmlReader = XmlReader.Create("..\\..\\Employees.xml")
        'Dim xEle As XElement = XElement.Load(xRead)
        'Console.WriteLine(xEle)
        'xRead.Close()

        ' 4. Find the second Employee Element
        ' Using XElement
        'Console.WriteLine("Using XElement")
        'Dim xEle As XElement = XElement.Load("..\..\Employees.xml")
        'Dim emp = xEle.Descendants("Employee").ElementAt(1)
        'Console.WriteLine(emp)

        'Console.WriteLine("------------")

        ''// Using XDocument
        'Console.WriteLine("Using XDocument")
        'Dim xDoc As XDocument = XDocument.Load("..\..\Employees.xml")
        'Dim emp1 = xDoc.Descendants("Employee").ElementAt(2)
        'Console.WriteLine(emp)

        ' 5. List the First 2 Employees
        'Dim xEle As XElement = XElement.Load("..\..\Employees.xml")
        'Dim emps = xEle.Descendants("Employee").Take(2)
        'For Each emp In emps
        '    Console.WriteLine(emp)
        'Next emp

        ' 6. List the 2nd and 3rd Employees
        'Dim xEle As XElement = XElement.Load("..\..\Employees.xml")
        'Dim emps = xEle.Descendants("Employee").Skip(1).Take(2)
        'For Each emp In emps
        '    Console.WriteLine(emp)
        'Next emp

        '7. List the Last 2 Employees
        'Dim xEle As XElement = XElement.Load("..\..\Employees.xml")
        'Dim emps = xEle.Descendants("Employee").Reverse().Take(2)
        'For Each emp In emps
        '    Console.WriteLine(emp.Element("EmpId") + emp.Element("Name"))
        'Next emp

        ' Display Only Values
        'Dim xEle As XElement = XElement.Load("..\..\Employees.xml")
        'Dim emps = xEle.Descendants("Employee").Reverse().Take(2)
        'For Each emp In emps
        '    Console.WriteLine(emp.Element("EmpId").Value & ". " & emp.Element("Name").Value)
        'Next emp

        'To display the results in order i.e display
        'Employee 3 and then 4 use Reverse().Take(2).Reverse();
        'Dim xEle As XElement = XElement.Load("..\..\Employees.xml")
        'Dim emps = xEle.Descendants("Employee").Reverse().Take(2).Reverse()
        'For Each emp In emps
        '    Console.WriteLine(emp.Element("EmpId").Value & ". " & emp.Element("Name").Value)
        'Next emp

        ' 8. Find the number of Employees living in the state CA
        Dim xelement As XElement = xelement.Load("..\..\Employees.xml")
        Dim stCnt = _
         From address In xelement.Elements("Employee") _
         Where CStr(address.Element("Address").Element("State")) = "CA" _
         Select address
        Console.WriteLine("No of Employees living in CA State are {0}", stCnt.Count())


        Console.ReadLine()
    End Sub

End Module
