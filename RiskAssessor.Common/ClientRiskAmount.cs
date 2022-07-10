using System;
using System.Collections.Generic;
using System.Text;

namespace RiskAssessor.Common
{
    public class ClientRiskAmount
    {
        public ClientRiskAmount(decimal riskAmount, string id, string firstName, string lastName)
        {
            RiskAmount = riskAmount;
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public decimal RiskAmount { get; set; }

        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
