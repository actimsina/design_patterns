using System;
using System.Collections.Generic;
using System.Linq;

namespace msapp
{
    class Program
    {
        static void Main(string[] args)
        {
            User u1 = new User();
            u1.Id = Guid.NewGuid();
            u1.Name = "Ram Kumar";
            u1.JobTitle = "Manager";


            User u2 = new User();
            u2.Id = Guid.NewGuid();
            u2.Name = "Sita Kumari";
            u2.JobTitle = "Accountant";

            u1.Obligations = new List<Obligation>{
                new Obligation
                {
                    Id = Guid.NewGuid(),
                    Description = "Sing",
                    StartTime = new DateTime(2018, 9, 11, 14, 0, 0),
                    Duration = 60,
                    Presence = Presence.Vital,
                },

                new Obligation
                {
                    Id = Guid.NewGuid(),
                    Description = "Work",
                    StartTime = new DateTime(2018, 9, 11, 10, 0, 0),
                    Duration = 60,
                    Presence = Presence.Optional,
                }
            };
            
            u2.Obligations = new List<Obligation>()
            {
                new Obligation()
                {
                    Id = Guid.NewGuid(),
                    Description = "Play",
                    StartTime = new DateTime(2018, 9, 11, 12, 0, 0),
                    Duration = 90,
                    Presence = Presence.Optional,
                }
            };

            Meeting m1 = new Meeting
            {
                Id = Guid.NewGuid(),
                Details = "Meeting for next event",
                Duration = 60,
                MinAttendees = 1,
                MaxAttendees = 4
            };

            MeetingSchedular ms = new MeetingSchedular(m1);

            ms.AddInvitee(u1);
            ms.AddInvitee(u2);
            // m1.RemoveInvitee(u);
            List<SuitablTimeSlot> suggestedTimeslots = ms.SuggestedTime(new DateTime(2018,9,11));
            SuitablTimeSlot ts =  suggestedTimeslots.Last();
            
            suggestedTimeslots.ForEach(sts => {
                Console.WriteLine(sts.StartTime+ " "+ sts.Users.Count);
            });
            // m1.SendInvitation();
            // m1.CheckInvitationStatus();
            // m1.updateObligations();
        }
    }
}
