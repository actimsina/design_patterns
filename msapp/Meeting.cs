using System;
using System.Collections.Generic;

namespace msapp
{
    public class Meeting
    {
        public Guid Id {get; set;}
        public string Details {get; set;}
        public DateTime MeetingTime {get; set;}
        public int Duration {get; set;}
        public int MinAttendees {get; set;}
        public int MaxAttendees {get; set;}

    }
}