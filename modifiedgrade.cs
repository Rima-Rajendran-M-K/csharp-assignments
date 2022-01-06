Student.cs



using System;

namespace A5
{
    partial class Program
    {
        class Student
        {
            public string name;
            public int age;
            public double  phy,chem,eng, math, his, obtd_marks, total_marks = 500, percentage;
            public double n;
           
            public Student()
            {
                

                name = "ANU";
                age = 23;
                phy = 97;
                eng = 90;
                math = 80;
                his = 50;
                chem = 76;
                
                

            }



            public void studentdata()
            {
                obtd_marks = phy + eng + math + his;
                Console.WriteLine("Name of the student:"+name);
                Console.WriteLine("Age of the student is"+age);
                Console.WriteLine("Total mark obtained=" + obtd_marks);

            }
            

            public void totalgrade()
            {

                if (obtd_marks >= 400 && obtd_marks <= 500)
                {
                    Console.WriteLine("Total:grade is A");
                }
                else if (obtd_marks >= 300 && obtd_marks < 400)
                {
                    Console.WriteLine("Total:grade is B");
                }
                else
                {
                    Console.WriteLine("Total:grade is C");
                }

                percentage = (obtd_marks / total_marks) * 100;
                Console.WriteLine("percentage is"+percentage);
            }
            public void grade(double n)
            {

                if (n >= 80 && n <= 100)
                {
                    Console.WriteLine("grade is A");
                }
                else if (n >= 60 && n < 80)
                {
                    Console.WriteLine("grade is B");
                }
                else
                {
                    Console.WriteLine("grade is C");
                }
            }
            public void subjectgrade(Student obj)
            {
                Console.WriteLine("Grade in Physics");
                grade(obj.phy);
                Console.WriteLine("Grade in chemistry");
                grade(obj.chem);
            }
        }
    }
}


program.cs

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5
{
    partial class Program
    {

        static void Main(string[] args)
        {
            
            var obj = new Student();
            obj.studentdata();
            
            obj.totalgrade();
            obj.subjectgrade();
