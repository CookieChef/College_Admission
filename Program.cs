using System;

namespace College_Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your high school grade point average");
            var userGradePoint = float.Parse(Console.ReadLine());
            

            Console.WriteLine("Now, please enter your admissions test score");
            var testScore = float.Parse(Console.ReadLine());

            if (userGradePoint >= 3.0 && testScore >= 60) {
                Console.WriteLine("Congratulations! You are accepted!");
                
            }else if (userGradePoint < 3.0 && testScore >= 80){
                Console.WriteLine("Congratulations! You are accepted!");
            }
            else {
                Console.WriteLine("We are sorry, you don't meet the requirements. Rejected");
            }
            
        }
    }
}
