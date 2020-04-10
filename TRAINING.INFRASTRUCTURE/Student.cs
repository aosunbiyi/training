using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace TRAINING.INFRASTRUCTURE
{
    public abstract class Student
    {

        public Student()
        {
            WriteLine("Student Constructor");
        }
        public string Name { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string RegNum { get; set; }
        

      

        public  void Register() {
            WriteLine("Register Method from Student Class");
        }

        protected  string GenerateReg()
        {
            Guid g = Guid.NewGuid();
            this.RegNum = g.ToString();
            return String.Format($"{g}");
        }

        internal void ShowPublicRegNumber()
        {
            WriteLine(this.RegNum);
        }

        public void ShowReg()
        {
            WriteLine(GenerateReg());
        }

        public virtual void CheckResult()
        {
            WriteLine("CheckResult Method from Student Class");
        }


        internal protected void ReSit()
        {
            WriteLine("Inside Resit Student Class");
        }


   
    }
}
