namespace Week4Assignment4._2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Data.studentList.Add(new Student() { SID = 1, Name = "Bob Ross", GPA = 3.75f });
            Data.studentList.Add(new Student() { SID = 2, Name = "Betty White", GPA = 3.0f });
            Data.studentList.Add(new Student() { SID = 3, Name = "Robin Williams", GPA = 4.0f });
            Application.Run(new Login());
        }
    }
}