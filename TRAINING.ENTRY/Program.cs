using System;
using static System.Console;
using TRAINING.INFRASTRUCTURE;
using TRAINING.SYNTAX;
using static TRAINING.SYNTAX.ClassObject.Console;
using System.Collections.Generic;

namespace TRAINING.ENTRY
{

    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();


            // Upcast 
            Student student1 = new UnderGraduateStudent();
            Student student2 = new UnderGraduateStudent();


            //DownCast
            UnderGraduateStudent underGraduateStudent = (UnderGraduateStudent)student1;
            underGraduateStudent.ComputeResult();

            double x = (double)77;

            object  x2 = (object)x;




            list.Add(student1);
            list.Add(student2);

            Student student3 = new PostGraduateStudent();
            Student student4 = new PostGraduateStudent();

            list.Add(student3);

            Student student5 = new GraduateStudent();
            Student student6 = new GraduateStudent();

            foreach (var student in list)
            {
                WriteLine(student.Name);

                if(student is PostGraduateStudent)
                {
                    PostGraduateStudent st = (PostGraduateStudent)student;
                    st.ComputeResult();

                    PostGraduateStudent st2 = student as PostGraduateStudent;
                    st2.ComputeResult();



                }
            }


           

        }
    }
}
