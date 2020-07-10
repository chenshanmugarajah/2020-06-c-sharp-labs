using System;

namespace lab_17_selection
{
    public class PassFailClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PassFailTernary(41));
        }

        public static string PassFailTernary(int mark)
        {
            return mark >= 40 ? "Pass" : "Fail";
        }

        public static string PassFail (int mark)
        {
            var grade = "Fail";
            if (mark >= 40)
            {
                grade = "Pass";
            }
            return grade;
        }

        public static string Grade (int mark)
        {
            if (mark >= 40 && mark <= 59) return "Pass";
            else if (mark >= 75 && mark <= 100) return "Pass with distinction";
            else if (mark >= 60 && mark <= 74) return "Pass with merit";
            else if (mark >= 0 && mark <= 39) return "Fail";
            else return "Invalid input";
        }

        public static string GradeNish(int mark)
        {
            var grade = "";
            if (mark >= 40)
            {
                grade = "Pass";
                if (mark >= 75)
                {
                    grade += " with Distinction";
                }
                else if (mark > -60)
                {
                    grade += " with Merit";
                }
            }
            else
            {
                grade = "Fail";
            }
            return grade;
        }

        public static string AlertLevel(int level)
        {
            string priority = "Code";
            switch (level)
            {
                case 3:
                    priority = priority + "Red";
                    break;
                case 2:
                case 1:
                    priority = priority + "Amber";
                    break;
                case 0:
                    priority = priority + "Green";
                    break;
                default:
                    priority = "error";
                    break;
            }
            return priority;
        }
    
    }
}
