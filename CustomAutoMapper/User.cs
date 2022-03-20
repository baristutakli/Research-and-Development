﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAutoMapper
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime  CreatedAt { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
