﻿using System;

namespace BankPCL.Abstractions.Interfaces.Strategies.Person_Strategies
{
    public interface IPersonMembershipStrategy
    {
        double? Priority { get; set; }

        double? Interest { get; set; }

        double? UpperLimit { get; set; }
        double? LowerLimit { get; set; }
    }
}