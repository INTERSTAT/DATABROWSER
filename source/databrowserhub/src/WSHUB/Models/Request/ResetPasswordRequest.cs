﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSHUB.Models.Request
{
    public class ResetPasswordRequest
    {
        public string Username { get; set; }
        public string Token { get; set; }
        public string Password { get; set; }
    }
}
