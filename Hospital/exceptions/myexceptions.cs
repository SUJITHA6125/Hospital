﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.exceptions
{
    namespace myexceptions
    {
        public class PatientNumberNotFoundException : Exception
        {
            public PatientNumberNotFoundException() : base("Patient number not found in the database.") { }
        }
    }
}
