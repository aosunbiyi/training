using System;
using System.Collections.Generic;
using System.Text;

namespace TRAINING.SYNTAX
{
    public abstract class AbtractDemo
    {
        public abstract void Test1() ;
        public void Test2() { }
    }

    public class Child : AbtractDemo
    {
        public override void Test1()
        {
            throw new NotImplementedException();
        }

        public new void Test2()
        {

        }
    }


}
