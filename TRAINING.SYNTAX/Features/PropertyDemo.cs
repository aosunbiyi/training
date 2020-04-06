using System;
using System.Collections.Generic;
using System.Text;

namespace TRAINING.SYNTAX.Features
{
    public class PropertyDemo
    {
        private int _pageNumber; 

        public int PageNumber
        {
            get { return _pageNumber; }
            set { 
                   if(value > 0)
                _pageNumber = value;
                   else
                _pageNumber = 0;
            
            }
        }

        public int TotalCount { get; set; }

        private int _account;

        public int Account
        {
            get { return _account; }
        }



    }
}
