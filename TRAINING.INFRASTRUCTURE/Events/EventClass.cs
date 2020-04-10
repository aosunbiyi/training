using System;
using System.Collections.Generic;
using System.Text;

namespace TRAINING.INFRASTRUCTURE.Events
{

    public delegate void EventHandlerDelegate(object sender, EventArgs args);
    public  class EventPublisher: System.Collections.ArrayList
    {

        public event EventHandlerDelegate Added;

        protected virtual void OnAdded(EventArgs args)
        {
            if (Added != null) Added(this,args);
        }
        public override int Add(object value)
        {
            int i= base.Add(value);
            OnAdded(EventArgs.Empty); //  Notifing the subscribers
            return i;
        }


    }
}
