using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public  class MeetingSchedule
    {
        public List<Meeting> Meetings = new List<Meeting>();
        public void SetMeeting (string fullName , DateTime from ,DateTime to)
        {
            //Ikinci hal
            // if (!Meetings.Exists(x => (x.FromDate < from && x.FromDate <to )||(x.ToDate > x.FromDate)))
            // if (!Meetings.Exists(x => (x.FromDate < from || x.FromDate < to) && (x.ToDate > x.FromDate || x.ToDate < x.FromDate)))
            // if (!Meetings.Exists(x => (x.FromDate <from && x.FromDate < to)))
            if (!Meetings.Exists(x => (x.FromDate > from && x.FromDate < to) || (x.ToDate < to && x.ToDate > from) || (from > x.FromDate && from < x.ToDate) || (to < x.ToDate && to > x.FromDate)))
            {
                Meeting meeting = new Meeting();
                meeting.Name = fullName;
                meeting.FromDate = from;
                meeting.ToDate = to;

                Meetings.Add(meeting);
            }
           
            else
            {
                throw new Exception("Bele araliqda  meeting artiq yardilib!!!!");
            }
        }
        public int FindMeetingsCount(DateTime dateTime)
        {
            return Meetings.FindAll(x => x.FromDate >= dateTime).Count;
        }

        public bool IsExistsMeetingByName(string name)
        {
            return (Meetings.Exists(x => x.Name == name));
        }

        public List<Meeting> GetExistMeetings(string name)
        {
            return Meetings.FindAll(x => x.Name == name);
        }

        //        Meetings - Meeting listi
        //SetMeeting(fullname, from, to) - göndərilmiş dəyərlərə əsasən meeting yaratmağa çalışır.
        //                                                        Əgər Göndərilmiş tarix intervalında meeting varsaException baş verir
        //                                                        hər şey okaydirsə meeting obyekti yaradıb meeting listinə add edir.



        //  FindMeetingsCount() - bu metod  parametr olaraq datetime qəbul edir və həmin date-dən sonra başlayan meetinglərin sayını qaytarır




        //  IsExistsMeetingByName() - bu metod parametr olaraq string qəbul edir və əgər meetings listində hansısa meetingin name dəyərində parametr olaraq göndərilən string dəyər varsa  true, yoxdursa false qaytarır



        //  GetExistMeetings() - bu metod parametr oıaraq name dəyəri qəbul edir və əgər meetings listində adında həmin dəyər olan meetinglerdən ibarət list qaytarır
    }
}
