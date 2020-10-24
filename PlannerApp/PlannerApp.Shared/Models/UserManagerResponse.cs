﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PlannerApp.Shared.Models
{
    public class UserManagerResponse
    {
        public string Message { get; set; }
        public bool IsSucces { get; set; }
        public string[] Errors { get; set; }
        public Dictionary<string,string> UserInfo { get; set; }
        public DateTime? ExpiredDate { get; set; }
    }
}
