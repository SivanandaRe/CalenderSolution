using CalenderBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderDL
{
    public class CalenderDataAccess
    {
        CalenderManagementEntities1 _context = new CalenderManagementEntities1();

        public List<tblCalender> GetAllCalenderData()
        {
            List<tblCalender> calenderList = _context.tblCalenders.ToList();
            return calenderList;
        }

        //public bool CreateAppointment(CalenderModel calenderModel)
        //{
        //    bool isExisting = true;
        //    tblCalender calender = _context.tblCalenders.FirstOrDefault(x => x.UserId == calenderModel.UserId
        //                           && x.CalenderDate == calenderModel.CalenderDate && x.CalenderTime == calenderModel.CalenderTime);
        //    if(calender == null) 
        //    {
        //     isExisting = false;
        //     tblCalender tblCalender = new tblCalender
        //    {
        //        Id = calenderModel.Id,
        //        CalenderDate = calenderModel.CalenderDate,
        //        CalenderTime = calenderModel.CalenderTime,
        //        IsappointmentBooked = calenderModel.IsappointmentBooked,
        //        UserId = calenderModel.UserId
        //    };

        //    _context.tblCalenders.Add(tblCalender);
        //    _context.SaveChanges();
        //    }

        //    return isExisting;
        //}

        //public int sum(int a, int b)
        //{
        //    int c;
        //    c = a + b;
        //    //bool d = true;
        //    return c; //ex number 1 or 2 3   // true  // datatype bool
        //}


    }
}
