using System;
using static System.Console;
using TRAINING.INFRASTRUCTURE;
using TRAINING.SYNTAX;
using TRAINING.SYNTAX.Features;
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

            PropertyDemo pd = new PropertyDemo();
            pd.PageNumber = 45;

            WriteLine(pd.PageNumber);

            //Indexer demo

            IndexerDemo id = new IndexerDemo();
            id[1] = 900;
            WriteLine(id[1]);
           

        }
    }
}
