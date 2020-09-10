using System;

namespace College_Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your high school grade point average");
            float userGradePoint = float.Parse(Console.ReadLine());

            Console.WriteLine("Now, please enter your admissions test score");
            float testScore = float.Parse(Console.ReadLine());
        }
    }
}
