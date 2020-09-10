using System;

namespace College_Admission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks user to enter the grade average, assigns a variable and converts that variable to a float
            Console.WriteLine("Please enter your high school grade point average");
            var userGradePoint = float.Parse(Console.ReadLine());
            
            //Asks user for the admision test score, assigns a variable and also converts to float
            Console.WriteLine("Now, please enter your admissions test score");
            var testScore = float.Parse(Console.ReadLine());

            //conditional statements to get accepted
            if (userGradePoint >= 3.0 && testScore >= 60) {
                Console.WriteLine("Congratulations! You are accepted!");

            //conditional statement to get accepted 
            }else if (userGradePoint < 3.0 && testScore >= 80){
                Console.WriteLine("Congratulations! You are accepted!");
            }
            //conditional statement for rejection
            else {
                Console.WriteLine("We are sorry, you don't meet the requirements. Rejected");
            }
            
        }
    }
}
