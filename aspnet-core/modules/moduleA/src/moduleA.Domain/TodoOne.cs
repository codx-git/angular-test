﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace moduleA
{
    public class TodoOne : Entity<Guid>
    {
        public string Content { get; set; }
        public bool IsDone { get; set; }
    }
}