namespace Day6
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region User
            HOD hod = new HOD("Dr. XYZ", 101, "Computer Science");

            Console.Write("Enter Examiner name: ");
            string ? examinerName = Console.ReadLine()!;
            Console.Write("Enter Examiner ID: ");
            int examinerID = int.Parse(Console.ReadLine()!);
            Examiner examiner = new Examiner(examinerName, examinerID);

            Semester semester = new Semester();
            Console.Write("Enter semester: ");
            int? semNum = int.Parse(Console.ReadLine()!);
            semester.Number = semNum;

            Exam exam = new Exam();
            Console.Write("Enter subject: ");
            string ? subject = Console.ReadLine();
            exam.Subject = subject;
            Console.Write("Enter date: ");
            string ? date = Console.ReadLine();
            exam.Date = date;
            exam.semester = semester;

            hod.ScheduleExam(semester, exam);
            hod.AssignExaminer(examiner, exam);
            #endregion
        }
    }
}
