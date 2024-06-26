﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller
{
    public class ParentDataTransferObject 
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ValidationCode { get; set; }
        public string UsernameOfChild { get; set; }

        public ParentDataTransferObject(string username, string firstName, string lastName, string password,
            string email, string address, string phoneNumber, string validationCode, string usernameOfChild)
        {
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            Email = email;
            Address = address;
            PhoneNumber = phoneNumber;
            ValidationCode = validationCode;
            UsernameOfChild = usernameOfChild;
        }
    }
}
