﻿using CleanArchitecture.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Domain.Core.Commands
{
    public abstract class Command : Message 
    {
        public DateTime Timestamp { get; set; }

        public Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
