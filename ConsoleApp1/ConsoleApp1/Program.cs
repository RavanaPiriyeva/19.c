using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeetingSchedule meetingSchedule = new MeetingSchedule();
    
       
            DateTime from = new DateTime(2022,3,3,4,0,0);
            DateTime to = new DateTime(2022 ,3,3,6,0,0);
            meetingSchedule.SetMeeting("aaa", from, to);
            DateTime from1 = new DateTime(2022,3,3,1,0,0);
            DateTime to1 = new DateTime(2022 ,3,3,8,0,0);
            meetingSchedule.SetMeeting("bbb", from1, to1);
            foreach (var item in meetingSchedule.Meetings)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
