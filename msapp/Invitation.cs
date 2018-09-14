using System;

namespace msapp
{
    public class Invitation
    {
        public Guid Id {get; set;}
        public Status Status {get; set;}
        public DateTime SentAt {get; set;}
        public DateTime RepliedAt {get; set;}
        public User Invitee {get; set;}
        public Meeting Meeting {get; set;}
    }

    public enum Status
    {
        Accepted,
        Rejected,
        Undecided
    }
}