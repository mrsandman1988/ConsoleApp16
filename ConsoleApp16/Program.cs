namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director d = new();
            School school = new School(d);
            school.City = "Vanadzor";
            Student student = new Student();
            student.FirstName = "John";
            student.LastName = "Smith";
            student.Age = 15;
            student.City = "Vanadzor";
            student.Level = 5;
          
            student.School = school;

            Student st = new();
            st.School = school;
            st.School.Name = "";
            student.GetStudentInfo();
            Console.WriteLine(st?.School?.Director?.FirstName);
        }
    }
}