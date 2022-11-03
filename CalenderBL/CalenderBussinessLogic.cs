using CalenderBO;
using CalenderDL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderBL
{
    public class CalenderBussinessLogic
    {
        CalenderDataAccess cda = new CalenderDataAccess();

        public List<CalenderModel> GetCalenderData()
        {
            List<tblCalender> tblCalenders = cda.GetAllCalenderData();
            List<CalenderModel> calenderList = new List<CalenderModel>();

            foreach(tblCalender calender in tblCalenders)
            {
                CalenderModel calenderModel = new CalenderModel();
                calenderModel.Id = calender.Id;
                calenderModel.FromDate = calender.FromDate;
                calenderModel.ToDate = calender.ToDate;
                calenderModel.UserId = calender.UserId;

                calenderList.Add(calenderModel);
            }

            return calenderList;
        }


    }
}
