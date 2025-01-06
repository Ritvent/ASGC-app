using System;
namespace ASGCapp
{
    class Program
    {
        static string assignments;
        static string quizzes;
        static void Main(string[] args)
        {
            Console.Write("Enter student's name: ");
            string studentName = Console.ReadLine();

            Console.WriteLine("Enter list of assignment scores like this (8/10 12/15 13/20)");
            assignments = Console.ReadLine();

            string[] scores = assignments.Split(' ');
            List<double> assignmentScores = new List<double>();

            foreach (string score in scores)
            {
                string[] nums = score.Split('/');
                double numScore = Convert.ToDouble(nums[0]);
                double numTotal = Convert.ToDouble(nums[1]);
                double calculateValue = (numScore / numTotal) * 100;
                assignmentScores.Add(calculateValue);
            }

            Console.WriteLine("Enter list of quiz scores like this (8/10 12/15 13/20)");
            quizzes = Console.ReadLine();

            string[] scoresQuizzes = quizzes.Split(' ');
            List<double> quizzesScores = new List<double>();

            foreach (string score in scoresQuizzes)
            {
                string[] nums = score.Split('/');
                double numScore = Convert.ToDouble(nums[0]);
                double numTotal = Convert.ToDouble(nums[1]);
                double calculateValue = (numScore / numTotal) * 100;
                quizzesScores.Add(calculateValue);
            }

            Console.WriteLine("\nEnter the final score like these examples: 85/100");
            Console.Write("Enter final exam score: ");
            string examFinalScore = Console.ReadLine();

            string[] finalExamScoreInput = examFinalScore.Split('/');
            double finalExamScore = Convert.ToDouble(finalExamScoreInput[0]) / Convert.ToDouble(finalExamScoreInput[1]) * 100;


            DisplayStudentReport(studentName, assignmentScores, quizzesScores, finalExamScore);


        }
        static double CalculatedWeightedAverage(List <double> quizScores, List <double> assignmentScores, double finalsScore) //Function 1
        {
            double assignmentPercentage = 0.20;
            double quizPercentage = 0.40;
            double finalsPercentage = 0.60;

            double assignmentAverage = assignmentScores.Average();
            double quizAverage = quizScores.Average();
                                        //(percentage * average) + (percentage * average)
            double weightedAverage = (assignmentPercentage * assignmentAverage) + (quizPercentage * quizAverage) + (finalsPercentage * finalsScore);

            return weightedAverage;
        }
        static string AssignLetterGrade(double weightedAverage) //Function 2
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

        static void DisplayStudentReport(string studentName, List <double> assignmentScores, List <double> quizScores, double finalsScore)//Function3
        {
            double weightedAverage = CalculatedWeightedAverage(quizScores, assignmentScores, finalsScore);
            string gradeMark = AssignLetterGrade(weightedAverage);

            Console.WriteLine();
            Console.WriteLine(">>>>>>Student Report<<<<<<");
            Console.WriteLine();
            Console.WriteLine($"Name: {studentName}");
            Console.WriteLine($"Assignment Scores: {assignments}");
            Console.WriteLine($"Quiz Scores: {quizzes}");
            Console.WriteLine($"Final Exam Score: {finalsScore}");
            Console.WriteLine($"Weighted Average: {weightedAverage}");
            Console.WriteLine($"Letter Grade: {gradeMark}");


        }
    }
}