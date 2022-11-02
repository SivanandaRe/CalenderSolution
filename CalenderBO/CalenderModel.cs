﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalenderBO
{
    public class CalenderModel
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> CalenderDate { get; set; }
        public Nullable<System.TimeSpan> CalenderTime { get; set; }
        public Nullable<bool> IsappointmentBooked { get; set; }
        public Nullable<int> UserId { get; set; }
    }
}
