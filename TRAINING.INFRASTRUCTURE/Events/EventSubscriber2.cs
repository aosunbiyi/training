using System;
using System.Collections.Generic;
using System.Text;

namespace TRAINING.INFRASTRUCTURE.Events
{
    public class EventSubscriber2
    {
        public void AddedEventHandler(object sender, EventArgs e)
        {

            Console.WriteLine("From EventSuscriber2 Added Event Occurred");
        }
    }
}
