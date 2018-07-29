﻿using System;

using BankPCL.Abstractions.Interfaces.Strategies.Person_Strategies;

namespace BankPCL.Implementations.Classes.Strategies.Account_Strategies
{
    public class DiamondMembershipStrategy : IMembershipStrategy
    {
        public double? Priority { get; set; }

        public double? Interest { get; set; }

        public double? UpperLimit { get; set; }
        public double? LowerLimit { get; set; }
    }
}
