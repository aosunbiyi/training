using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace TRAINING.INFRASTRUCTURE.Enums
{
    public class Sample1
    {
        enum MachineState {STOP = 10, RUN,  WAIT };

        public void Run()
        {

          
            Machine m = new Machine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Error.WriteLine(($"{(int)m.MachineState} == {m.MachineState}"));
            m.MachineState = MachineState.WAIT;
            Error.WriteLine($"{(int)m.MachineState} == {m.MachineState}");

            using (Machine  ma = new Machine()) {
                Console.WriteLine(ma.Name);
            
            }

            try {
                m.Divider(5,0);
            
           }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        class Machine: IDisposable
        {
            public int MachineID  { get; set; }
            public string Name { get; set; }

            private MachineState _machineState = MachineState.STOP;
            public MachineState MachineState
            {
                get { return _machineState; }

                set
                {
                    switch (value)
                    {
                        case MachineState.RUN:
                            _machineState = MachineState.RUN;
                            break;
                        case MachineState.STOP:
                            _machineState = MachineState.STOP;
                            break;

                        case MachineState.WAIT:
                            _machineState = MachineState.WAIT;
                            break;
                        default:
                            _machineState = MachineState.STOP;
                            break;
                    }
                }
            }

            public void Divider(int upper, int lower)
            {
                if(lower == 0)
                {
                    throw new OutOfMemoryException("Custom Message from the Server");
                }
            }

            public void Dispose()
            {
                
            }
        }
    }


}
