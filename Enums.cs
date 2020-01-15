using System;

namespace Labs2
{
    enum EmpType : byte
    {
        Grunt = 1,
        VP = 9,
        Manager = 10,
        Contractor = 100
    }
    struct Employee
    {
        public EmpType title;
        public string name;
        public short deptID;
    }
    struct EmployeeWithConstruct
    {
        public EmpType title;
        public string name;
        public short deptID;
        public EmployeeWithConstruct(EmpType empType, string empName, short empDeptID)
        {
            title = empType;
            name = empName;
            deptID = empDeptID;
        }
    }
    class StructTester
    {
        public static void TestEnumsWithoutConstruct()
        {
            Employee fred;
            fred.deptID = 40;
            fred.name = "Fred";
            fred.title = EmpType.Grunt;
            Console.WriteLine(fred.deptID);
            Console.WriteLine(fred.name);
            Console.WriteLine(fred.title);
        }
        public static void TestEnumsWithConstruct()
        {
            EmployeeWithConstruct maгу = new EmployeeWithConstruct(EmpType.VP, "Mary", 10);
            Console.WriteLine(maгу.deptID);
            Console.WriteLine(maгу.name);
            Console.WriteLine(maгу.title);
        }

    }
}
