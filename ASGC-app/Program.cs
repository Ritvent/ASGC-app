using System;
namespace ASGCapp
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static void Function1()
        {

        }
        static string AssignLetterGrade(double weightedAverage)
        {
            if (weightedAverage >= 90 && weightedAverage <= 100)
            {
                return "A";
            }
            else if (weightedAverage >= 80)
            {
                return "B";
            }
            else if (weightedAverage >= 70)
            {
                return "C";
            }
            else if (weightedAverage >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        static void Function3()
        {

        }
    }
}