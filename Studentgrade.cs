STUDENT.CS

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
            public void physicsgrade()
            {
                
                if (phy >= 80 && phy <= 100)
                {
                    Console.WriteLine("physics:grade is A");
                }
                else if (phy >= 60 && phy < 80)
                {
                    Console.WriteLine("physics:grade is B");
                }
                else
                {
                    Console.WriteLine("physics:grade is C");
                }
            }

                public void englishgrade()
                {
                    if (eng >= 80 && eng <= 100)
                    {
                        Console.WriteLine("english:grade is A");
                    }
                    else if (eng >= 60 && eng < 80)
                    {
                        Console.WriteLine("english:grade is B");
                    }
                    else
                    {
                        Console.WriteLine("english:grade is C");
                    }

                


                }
            public void chemistrygrade()
            {
                if (chem >= 80 && chem <= 100)
                {
                    Console.WriteLine("chemistry:grade is A");
                }
                else if (chem >= 60 && chem < 80)
                {
                    Console.WriteLine("chemistry:grade is B");
                }
                else
                {
                    Console.WriteLine("chemistry:grade is C");
                }
            }

            public void historygrade()
            {
                if (his >= 80 && his <= 100)
                {
                    Console.WriteLine("history:grade is A");
                }
                else if (his >= 60 && his < 80)
                {
                    Console.WriteLine("history:grade is B");
                }
                else
                {
                    Console.WriteLine("history:grade is C");
                }
            }

            public void mathsgrade()
            {
                if (math >= 80 && math <= 100)
                {
                    Console.WriteLine("maths:grade is A");
                }
                else if (math >= 60 && math < 80)
                {
                    Console.WriteLine("maths:grade is B");
                }
                else
                {
                    Console.WriteLine("maths:grade is C");
                }
            }

            public void totalgrade()
            {

                if (phy >= 400 && phy <= 500)
                {
                    Console.WriteLine("Total:grade is A");
                }
                else if (phy >= 300 && phy < 400)
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
            }
    }
}

PROGRAM.CS

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
            obj.englishgrade();
            obj.physicsgrade();
            obj.chemistrygrade();
            obj.mathsgrade();
            obj.historygrade();
            obj.totalgrade();

        }
    }
}
