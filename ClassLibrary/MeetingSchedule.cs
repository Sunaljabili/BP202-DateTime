using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class MeetingSchedule
    {
        public List<Meeting> meetings = new List<Meeting>();
        public void SetMeeting(string fullname,DateTime from, DateTime to)
        {
            if (!meetings.Exists(x=>(x.FromDate>from || x.FromDate>to) && (x.ToDate<from || x.ToDate<to)))
            {
                Meeting meeting = new Meeting()
                {
                    Name = fullname,
                    FromDate = from,
                    ToDate = to,
                };
                meetings.Add(meeting);
            }
            else
            {
                throw new Exception("Bu vaxtda gorush var!");
            }
        }

        public int FindMeetingsCount(DateTime dateTime)
        {
            return meetings.FindAll(x => x.FromDate > dateTime).Count;
        }

        public bool IsExistsMeetingByName(string name)
        {
            return meetings.Exists(x => x.Name.Contains(name));
        }

        public List<Meeting> GetExistMeetings(string name)
        {
            return meetings.FindAll(x => x.Name.Contains(name));
        }
    }
}
