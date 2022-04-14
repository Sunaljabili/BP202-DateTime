using System;
using System.IO;
using ClassLibrary;
namespace DateTimeHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Meeting meeting1 = new Meeting()
            {
                Name = "interview1",
                FromDate = new DateTime(2022,4,13,2,16,0),
                ToDate = new DateTime(2022,4,13,3,16,0)
            };
            MeetingSchedule meetingSchedule = new MeetingSchedule();
            
            meetingSchedule.meetings.Add(meeting1);
            meetingSchedule.SetMeeting("interview", new DateTime(2022, 4, 13, 1, 16, 0), new DateTime(2022, 4, 13, 2, 06, 0));
            //meetingSchedule.SetMeeting("interview", new DateTime(2022, 4, 13, 1, 16, 0), new DateTime(2022, 4, 13, 4, 36, 0));
            Console.WriteLine("============All Meetings============");
            foreach (var item in meetingSchedule.meetings)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("============Find meetings count============");
            Console.WriteLine(meetingSchedule.FindMeetingsCount(new DateTime(2022, 4, 13, 1, 16, 0)));

            Console.WriteLine("============Is exists meeting by name============");
            Console.WriteLine(meetingSchedule.IsExistsMeetingByName("."));

            Console.WriteLine("============Get exists meetings============");
            foreach (var item in meetingSchedule.GetExistMeetings("1"))
            {
                Console.WriteLine(item.Name);
            }


        }


    }
    
}
