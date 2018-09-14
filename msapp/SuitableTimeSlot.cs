using System;
using System.Collections.Generic;

namespace msapp
{
    public class SuitablTimeSlot
    {
        public SuitablTimeSlot()
        {
            Users = new List<User>();
        }
        public DateTime StartTime { get; set; }
        public int Duration {get; set;}
        public List<User> Users {get; set;}
    }
}