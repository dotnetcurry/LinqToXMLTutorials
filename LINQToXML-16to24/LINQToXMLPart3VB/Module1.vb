Imports System.IO
Imports System.Xml.Linq

Module Module1

    Sub Main()
        ' 1. Add a new XElement at runtime
        'Dim xEle As XElement = XElement.Load("..\..\Employees.xml")
        'xEle.Add(New XElement("Employee", _
        '                      New XElement("EmpId", 5), _
        '                      New XElement("Name", "George")))

        'Console.Write(xEle)

        '' 2. Add a new XElement as the FirstChild
        'Dim xEle As XElement = XElement.Load("..\..\Employees.xml")
        'xEle.AddFirst(New XElement("Employee", _
        '    New XElement("EmpId", 5), _
        '    New XElement("Name", "George")))

        'Console.Write(xEle)

        '' 3. Add an Attribute to an Element
        'Dim xEle As XElement = XElement.Load("..\..\Employees.xml")
        'xEle.Add(New XElement("Employee", _
        '                      New XElement("EmpId", 5), _
        '                      New XElement("Phone", "423-555-4224", _
        '                                   New XAttribute("Type", "Home"))))

        'Console.Write(xEle)

        '' 4. Replace the content of an Element
        'Dim xEle As XElement = XElement.Load("..\..\Employees.xml")
        'Dim countries = xEle.Elements("Employee").Elements("Address").Elements("Country").ToList()
        'For Each cEle As XElement In countries
        '    cEle.ReplaceNodes("United States Of America")
        'Next cEle

        'Console.Write(xEle)

        '' 5. Remove Attribute from all the Elements
        'Dim xEle As XElement = XElement.Load("..\..\Employees.xml")
        'Dim phone = xEle.Elements("Employee").Elements("Phone").ToList()
        'For Each pEle As XElement In phone
        '    pEle.RemoveAttributes()
        'Next pEle

        'Console.Write(xEle)

        '' 6. Delete an Element Based on a Condition
        'Dim xEle As XElement = XElement.Load("..\..\Employees.xml")
        'Dim addr = xEle.Elements("Employee").ToList()
        'For Each addEle As XElement In addr
        '    addEle.SetElementValue("Address", Nothing)
        'Next addEle

        'Console.Write(xEle)

        '' 7. Delete 'n' number of Elements            
        'Dim xEle As XElement = XElement.Load("..\..\Employees.xml")
        'Dim emps = xEle.Descendants("Employee")
        'emps.Reverse().Take(2).Remove()

        'Console.Write(xEle)


        '' 8. Persists changes to the XML
        'Dim xEle As XElement = XElement.Load("..\..\Employees.xml")
        'xEle.Add(New XElement("Employee", _
        '                      New XElement("EmpId", 5), _
        '                      New XElement("Name", "George"), _
        '                      New XElement("Sex", "Male"), _
        '                      New XElement("Phone", "423-555-4224", _
        '                                   New XAttribute("Type", "Home")), _
        '                                   New XElement("Phone", "424-555-0545", _
        '                                                New XAttribute("Type", "Work")), _
        '                                                New XElement("Address", _
        '                                                             New XElement("Street", "Fred Park, East Bay"), _
        '                                                             New XElement("City", "Acampo"), _
        '                                                             New XElement("State", "CA"), _
        '                                                             New XElement("Zip", "95220"), _
        '                                                             New XElement("Country", "USA"))))

        'xEle.Save("..\..\Employees.xml")
        'Console.WriteLine(xEle)

        Console.ReadLine()
    End Sub

End Module
