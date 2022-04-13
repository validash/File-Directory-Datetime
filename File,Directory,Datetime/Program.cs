using Models;
using System;

namespace File_Directory_Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Meeting meeting1 = new Meeting();
            meeting1.Name = "Meeting1";
            DateTime fromDate1 = new DateTime(2022, 3, 15, 10, 0, 0);
            meeting1.FromDate = fromDate1;
            DateTime toDate1 = new DateTime(2022, 3, 15, 11, 50, 0);
            meeting1.ToDate= toDate1;

            Meeting meeting2 = new Meeting();
            meeting2.Name = "Meeting2";
            DateTime fromDate2= new DateTime(2022, 3, 16, 13, 0, 0);
            meeting2.FromDate = fromDate2;
            DateTime toDate2 = new DateTime(2022, 3, 16, 15, 30, 0);
            meeting2.ToDate = toDate2;

            Meeting meeting3 = new Meeting();
            meeting3.Name = "Meeting3"; 
            DateTime fromDate3 = new DateTime(2022, 3, 18, 9, 0, 0);
            meeting3.FromDate = fromDate3;
            DateTime toDate3 = new DateTime(2022, 3, 18, 11, 50, 0);
            meeting3.ToDate = toDate3 ;
            
            MeetingSchedule meetingSchedule = new MeetingSchedule();
            meetingSchedule.SetMeeting("Meeting1", new DateTime(2022, 3, 15, 10, 0, 0), new DateTime(2022, 3, 15, 11, 50, 0));
            meetingSchedule.SetMeeting("Meeting2", new DateTime(2022, 3, 16, 13, 0, 0), new DateTime(2022, 3, 16, 15, 30, 0));
            meetingSchedule.SetMeeting("Meeting3", new DateTime(2022, 3, 18, 9, 0, 0), new DateTime(2022, 3, 18, 11, 50, 0));

            //foreach (var item in meetingSchedule.Meetings)
            //{
            //    Console.WriteLine(item.Name);
            //}

            int count = meetingSchedule.FindMeetingsCount(toDate1);
            Console.WriteLine(count);

            Console.WriteLine(meetingSchedule.IsExistsMeetingByName("Meeting2"));

            foreach (var item in meetingSchedule.GetExistMeetings("Meeting"))
            {
                Console.WriteLine($"Meeting Name:{item.Name}"+" "+ $"FromDate:{item.FromDate}" +" "+ $"ToDate:{item.ToDate}");
            }
        }
    }
}
