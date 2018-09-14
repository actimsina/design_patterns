using System;
namespace msapp
{
    public class Obligation
    {
        public Guid Id {get; set;}
        public string Description {get; set;}
        public DateTime StartTime {get; set;}
        public int Duration {get; set;}
        public Presence Presence {get; set;}
    }

    public enum Presence 
    {
        Vital,
        Optional
    }
}