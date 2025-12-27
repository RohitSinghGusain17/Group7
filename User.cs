namespace Day6
{
    public class User
    {
        public string? Name;
    }

    public class Employee : User
    {
        public int EmpID;
    }

    public class Student : User
    {
        public int RollNo;
        public int Semester;

        public Student(string nameInput, int RollNoInput , int semester)
        {
            RollNo=RollNoInput;
            Name=nameInput;
            Semester=semester;
        }
    }

    public class HOD : Employee
    {
        public string? Department;
        public HOD(string nameInput, int EmpIDInput, string DepartmentInput){
            Name=nameInput;
            EmpID=EmpIDInput;
            Department=DepartmentInput;
        }

        public void ScheduleExam(Semester semester, Exam exam)
        {
            Console.WriteLine($"Exam for {exam.Subject} in Semester {semester.Number} has been scheduled by HOD {Name} on {exam.Date}");
        }

        public void AssignExaminer(Examiner examiner, Exam exam)
        {
            Console.WriteLine($"HOD {Name} has assigned Examiner {examiner.Name} for subject {exam.Subject}");
            examiner.ConductExam(exam);
        }
    }

    public class Examiner : Employee
    {
        public Examiner(string nameInput, int EmpIDInput){
            Name=nameInput;
            EmpID=EmpIDInput;
        }

        public void ConductExam(Exam exam)
        {
            Console.WriteLine($"Exam for {exam.Subject} is being conducted by {Name}");
        }
    }
}