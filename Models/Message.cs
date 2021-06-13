﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ForumAPI.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public Guid MessageToUser { get; set; }
        public Guid MessageFromUser { get; set; }

    }
}
