using System;
using System.Collections.Generic;
using System.Text;

namespace TRAINING.INFRASTRUCTURE.Events
{
    public  class EventSubscriber1
    {
        public void AddedEventHandler(object sender,EventArgs e) {

            Console.WriteLine("From EventSuscriber1 Added Event Occurred");
        }
    }
}
