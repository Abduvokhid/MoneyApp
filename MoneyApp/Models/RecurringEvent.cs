﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyApp.Models
{
    public class RecurringEvent : Event
    {
        public string Status { get; set; }
        public DateTime EndDate { get; set; }
    }
}