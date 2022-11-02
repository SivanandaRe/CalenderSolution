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
        CalenderManagementEntities _context = new CalenderManagementEntities();

        public List<CalenderModel> GetAllApointments()
        {
           List<tblCalender> appointmentsList = _context.tblCalenders.ToList();

            List<CalenderModel> calenderModels = new List<CalenderModel>();

            foreach(tblCalender appointment in appointmentsList)
            {
                CalenderModel calenderModel = new CalenderModel
                {
                    Id = appointment.Id,
                    CalenderDate = appointment.CalenderDate,
                    CalenderTime = appointment.CalenderTime,
                    IsappointmentBooked = appointment.IsappointmentBooked,
                    UserId = appointment.UserId
                };
                calenderModels.Add(calenderModel);
            }

            return calenderModels;

        }

        public  bool CreateAppointment(CalenderModel calenderModel)
        {
            bool isExiting = true;
            tblCalender calender = _context.tblCalenders.FirstOrDefault(x => x.UserId == calenderModel.UserId
                                                       && x.CalenderDate == calenderModel.CalenderDate && x.CalenderTime == calenderModel.CalenderTime);

            if(calender == null) 
            {
                isExiting = false;
                tblCalender tblCalender = new tblCalender
            {
                Id = calenderModel.Id,
                CalenderDate = calenderModel.CalenderDate,
                CalenderTime = calenderModel.CalenderTime,
                IsappointmentBooked = calenderModel.IsappointmentBooked,
                UserId = calenderModel.UserId
            };

            _context.tblCalenders.Add(tblCalender);
            _context.SaveChanges();

            }

            return isExiting;

        }


    }
}
