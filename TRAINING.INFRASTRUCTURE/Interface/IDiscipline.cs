using System;
using System.Collections.Generic;
using System.Text;

namespace TRAINING.INFRASTRUCTURE.Interface
{
    public interface IDiscipline
    {
        void Report();
         string ReportDetails { get; set; }
    }
}
