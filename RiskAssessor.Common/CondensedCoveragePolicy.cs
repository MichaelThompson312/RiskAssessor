using System;
using System.Collections.Generic;
using System.Text;

namespace RiskAssessor.Common
{
    public class CondensedCoveragePolicy
    {
        public CondensedCoveragePolicy(decimal cashValue, decimal faceAmount, string id, string firstName, string lastName)
        {
            CashValue = cashValue;
            FaceAmount = faceAmount;
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public decimal CashValue { get; set; }

        public decimal FaceAmount { get; set; }
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
