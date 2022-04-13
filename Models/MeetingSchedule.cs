using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class MeetingSchedule
    {
        public List<Meeting> Meetings = new List<Meeting>();

        public void SetMeeting(string name,DateTime fromDate,DateTime toDate)
        {
            if (Meetings.Exists(x => x.Name == name) && (Meetings.Exists(x => x.FromDate < fromDate && x.ToDate < fromDate) || Meetings.Exists(x => x.FromDate > toDate && x.ToDate > toDate)))
            {
                throw new Exception("Bele Meeting movcuddur.");
            }

            else
            {

                Meeting addedMeeting = new Meeting();
                addedMeeting.Name = name;
                addedMeeting.FromDate = fromDate;
                addedMeeting.ToDate = toDate;

                Meetings.Add(addedMeeting);
            }
        }

        public int FindMeetingsCount(DateTime dt)
        {
            int count = 0;
            if (Meetings.Exists(x=>x.FromDate>dt))
            {
                foreach (var item in Meetings)
                {
                    if (item.FromDate>dt)
                    {
                        count++;   
                    }
                }
            }
            return count;
        }

        public bool IsExistsMeetingByName(string meetingName)
        {
            if (Meetings.Exists(x => x.Name.Contains(meetingName)))
            {
                return true;
            }
            return false;
        }

        public List<Meeting> GetExistMeetings(string meetingName)
        {
            if (Meetings.Exists(x => x.Name.Contains(meetingName)))
            {
                return Meetings.FindAll(x => x.Name.Contains(meetingName));
            }
            return null;
        }
    }
}
