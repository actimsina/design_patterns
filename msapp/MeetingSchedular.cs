using System;
using System.Collections.Generic;

namespace msapp
{
    public class MeetingSchedular
    {
        private Meeting _meeting;
        private List<User> _invitees = new List<User>();
        public MeetingSchedular(Meeting meeting){
            _meeting = meeting;
        }
        public void AddInvitee(User u)
        {
            if(!_invitees.Contains(u))
            {
                _invitees.Add(u);
            }
        }
        public void RemoveInvitee(User u)
        {
            if(_invitees.Contains(u))
            {
                _invitees.Remove(u);
            }
        }
        public List<SuitablTimeSlot> SuggestedTime(DateTime SearchTime){
            SearchTime = SearchTime.AddHours(9);
            DateTime SearchEndTime = SearchTime.AddHours(8);
            List<SuitablTimeSlot> _freeTimeSlots = new List<SuitablTimeSlot>();
            while(SearchTime < SearchEndTime)
            {
                SuitablTimeSlot _freeTimeSlot = new SuitablTimeSlot();
                _freeTimeSlot.StartTime = SearchTime;
                _freeTimeSlot.Duration = _meeting.Duration;
                foreach(var user in _invitees)
                {
                    if(!IsInInterval(SearchTime, _meeting.Duration, user.Obligations))
                    {
                        if(!_freeTimeSlot.Users.Contains(user)) _freeTimeSlot.Users.Add(user);
                        if(!_freeTimeSlots.Contains(_freeTimeSlot)) _freeTimeSlots.Add(_freeTimeSlot);
                    }
                }
                SearchTime = SearchTime.AddMinutes(60);
            }
           _freeTimeSlots.Sort((a, b) => a.Users.Count.CompareTo(b.Users.Count));
        // _freeTimeSlots.Sort();
           return _freeTimeSlots;
        }

        private bool IsInInterval(DateTime StartTime, int Duration, List<Obligation> obligations){
            foreach(var obligation in obligations)
            {
                if((StartTime < obligation.StartTime.AddMinutes(obligation.Duration)) && (StartTime.AddMinutes(Duration) > obligation.StartTime)){
                    return true;
                }
            }
            return false;
        }
    }
}