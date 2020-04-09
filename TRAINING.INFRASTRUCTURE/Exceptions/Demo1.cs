using System;
using System.Collections.Generic;
using System.Text;

namespace TRAINING.INFRASTRUCTURE.Exceptions
{
     public class Demo1
    {

        public void Run()
        {
            Database db = null;

            try
            {
                db = new Database();
                db.Open();
                var list = db.Read();
                db.Close();
            }
            catch (IndexOutOfRangeException ex) { 
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (db.IsOpen())
                {
                    db.Close();
                }
            }
            
        }

        
        public class Database
        {
           public void Open() { }
            public bool IsOpen()
            {
                return true;
            }
            public string  Read() { return ""; }
            public void Close() { }
        }
    }
}
