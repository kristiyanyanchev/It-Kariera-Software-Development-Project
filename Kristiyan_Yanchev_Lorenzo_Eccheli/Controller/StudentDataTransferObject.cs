﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller
{
    class StudentDataTransferObject
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ValidationCode { get; set; }
        public string Class { get; set; }
        public string Ucn { get; set; }
        public DateTime BirthDate { get; set; }

    }
}