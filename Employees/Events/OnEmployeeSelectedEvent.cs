﻿using DAL_LocalDb;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Events
{
    public class OnEmployeeSelectedEvent : PubSubEvent<int> { }
}
