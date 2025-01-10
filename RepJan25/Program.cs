// See https://aka.ms/new-console-template for more information

using RepJan25;
using System.ComponentModel;
// before implementing abstract class and calculate salary
Employee e1 = new Employee(200, 1, "Poul", "12121212"); // "e1" er objekt reference
// uden en override ToString printes "RepJan25.Employee" folderen og klassen
Teacher t1 = new Teacher("Teknologi", 200, 2, "Mikkel", "34343434");
Secretary s1 = new Secretary(true, 200, 3, "Amalie", "56565656");
//Console.WriteLine(e1);
//Console.WriteLine(t1);
//Console.WriteLine(s1);

//Erklæret type     Aktuelle type
Employee ep = new Employee(200, 4, "Anette", "78787878");
//Console.WriteLine(ep); // Employee ToString
ep = new Teacher("Teknologi", 200, 4, "Anette", "78787878");
//ep = new Teacher("Programming", 200, 4, "Anette", "97979797");
//Console.WriteLine(ep); // Teacher ToString
// Aktuelle type bestemmer hvilken virtual/override metode der kaldes

// Erklæret type bestemmer hvad der kan kaldes
//Console.WriteLine($"Name {ep.Name}"); // kan kaldes
//Console.WriteLine($"Subject {ep.Subject}"); // kan ikke kaldes

/*
// When the above is commented out, use this instead
Employee ep = new Employee(200, 4, "Anette", "78787878");
ep = new Teacher("Teknologi", 200, 4, "Anette", "78787878");
*/

// Polymorfi, dette kan optræde i forskellige former
List<Employee> employees = new List<Employee>();
employees.Add(e1); employees.Add(t1); employees.Add(s1); employees.Add(ep);
//foreach (Employee emp in employees)
//{
//    Console.WriteLine(emp);
//    //Console.WriteLine($"Pension {emp.CalculatePension()}");
//}

IEmployeeRepositoryList empList = new EmployeeRepositoryList();
foreach (Employee emp in employees)
{
    empList.AddEmployee(emp);
}

//option 1
//double SalarySum = empList.CalculateTotalSalarySum();
//Console.WriteLine(SalarySum);
//option 2
//Console.WriteLine(empList.CalculateTotalSalarySum());

IEmployeeRepositoryDictionary empDict = new EmployeeRepositoryDictionary();
foreach (Employee emp in employees)
{
    empDict.AddEmployee(emp);
}
empDict.UpdateEmployee(new Teacher("Programmering", 200, 4, "Anette", "97979797"));

foreach (Employee emp in empDict.GetAllEmployee())
{
    Console.WriteLine(emp);
}

//Console.WriteLine(empDict.CalculateTotalSalarySum());

//Console.WriteLine(ep.CalculateSalary());

/* // når klassen er abstrakt
//Teacher t1 = new Teacher("Teknologi", 200, 2, "Mikkel", "34343434");
//Secretary s1 = new Secretary(true, 200, 3, "Amalie", "56565656");

Console.WriteLine(t1);
Console.WriteLine(s1);

//Employee ep = new Teacher("Teknologi", 200, 4, "Anette", "78787878");

// Polymorfi, dette kan optræde i forskellige former
List<Employee> employees = new List<Employee>();
employees.Add(t1); employees.Add(s1); employees.Add(ep);
foreach (Employee emp in employees)
{
    Console.WriteLine($"Pension {emp.CalculatePension()}");
}
*/