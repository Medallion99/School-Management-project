// See https://aka.ms/new-console-template for more information
using School_System;
using School_System.Helper;
using School_System.Model;
using School_System.Model.Dtos;
using SchoolSystem.Logic;
using SchoolSystem.Model;

GlobalConfig.Initiate();

        Console.WriteLine("WELCOME TO MEDALLION SCHOOL STUDENT MANAGEMENT SYSTEM");

        bool criteria = true;
        while (criteria)
        {
            Console.WriteLine("What is your first name");
            string firstn = Console.ReadLine();
            Console.WriteLine("What is your Last name");
            string lastn = Console.ReadLine();
            Console.WriteLine("When did you resume(DD/MM/YYY) ?");
            string start = Console.ReadLine();
            Console.WriteLine("When is your fee due (DD/MM/YYY) ?");
            string end = Console.ReadLine();
            Console.WriteLine("What is your gender ?");
            string sex = Console.ReadLine();
            Console.WriteLine("How old are You");
            string age = Console.ReadLine();
            Console.WriteLine("What was your Common Entrance Score");
            string grade = Console.ReadLine();

            var stud = new Student
            {
                FirstName = firstn,
                LastName = lastn,
                RegisterOn = start,
                ToPayOn = end,
                Gender = sex,
                Age = age,
                Grade = grade,
                ActiveStatus = true
            };
            var addStudent = GlobalConfig._studentLogic.Addstudent(stud);
            Console.WriteLine(addStudent);

            Console.WriteLine($"Please enter the following details for {stud.FirstName}");
            Console.WriteLine("How much is students' schoolfees ?");
            var schfees = decimal.Parse(Console.ReadLine());
            Console.WriteLine("How much is students' sportfee ?");
            var sport = decimal.Parse(Console.ReadLine());
            Console.WriteLine("How much did student spend in the restaurant ?");
            var rest = decimal.Parse(Console.ReadLine());
            Console.WriteLine("How much is students' PA levy ?");
            var pa = decimal.Parse(Console.ReadLine());
            Console.WriteLine("How much is students' Library cost ?");
            var book = decimal.Parse(Console.ReadLine());

            var record = new Record
            {
                SchoolFees = schfees,
                Sportfee = sport,
                Restaurantfee = rest,
                PAfee = pa,
                Books = book
            };
            var addRecord = GlobalConfig._recordLogic.AddStudentRecord(record);
            Console.WriteLine(addRecord);

            Console.WriteLine("Do you wish to continue (YES / NO) ?");
            var ans = Console.ReadLine().ToUpper();
            if (ans == "YES")
                criteria = false;
        }

        Console.WriteLine();
        Console.WriteLine("Would you like to print student record (Y / N)?");
        string reply = Console.ReadLine().ToUpper();
        if (reply == "N")
            Environment.Exit(0);

        var students = GlobalConfig._studentLogic.GetStudents();
        var records = GlobalConfig._recordLogic.GetRecords();

        var recordDtos = students.Join(records, x => x.id, y => y.StudentId, (x, y) => new RecordDto
        {
            StudentName = $"{x.FirstName} {x.LastName}",
            RegNumber = x.RegNumber,
            Gender = x.Gender,
            Grade = x.Grade,
            RegisteredOn = x.RegisterOn,
            DueOn = x.ToPayOn,
            ActiveStatus = x.ActiveStatus,
            SchoolFees = y.SchoolFees,
            Sportfee = y.Sportfee,
            Restaurantfee = y.Restaurantfee,
            PAfee = y.PAfee,
            Books = y.Books,
            Total = y.Total,
            AnnualFee = y.AnnualFee,            
        });

        Console.WriteLine();

        var headers = new string[] {"StudentName","RegNum","Gender","Grade",
                                      "Registered-On","Due-On","Status","Schoolfee",
                                      "Sportfee","Restaurantfee","PAfee","libraryfee",
                                      "Total","Annualfee"};

        Utility.PrintLine(Console.WindowWidth - 2);
        Utility.PrintRow(Console.WindowWidth - 2, headers);
        Utility.PrintLine(Console.WindowWidth - 2);

        foreach (var row in recordDtos)
        {
            Utility.PrintRow (Console.WindowWidth - 2, row.StudentName.ToString(),
                                                        row.RegNumber.ToString(), 
                                                        row.Gender.ToString(), 
                                                        row.Grade.ToString(), 
                                                        row.RegisteredOn.ToString(), 
                                                        row.DueOn.ToString(), 
                                                        row.ActiveStatus.ToString(),
                                                        row.SchoolFees.ToString(), 
                                                        row.Sportfee.ToString(), 
                                                        row.Restaurantfee.ToString(), 
                                                        row.PAfee.ToString(), 
                                                        row.Books.ToString(),
                                                        row.Total.ToString(), 
                                                        row.AnnualFee.ToString());
        }Utility.PrintLine(Console.WindowWidth - 2);
        Console.WriteLine();