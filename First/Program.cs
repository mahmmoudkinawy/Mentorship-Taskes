namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Kinawy");

            student.AddGrade(90);
            student.AddGrade(90);
            student.AddGrade(20);

            student.ShowAllData();
        }
    }
}
