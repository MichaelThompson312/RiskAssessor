using System;
using System.Collections.Generic;
using System.Text;

namespace RiskAssessor.Common
{
    public class CoveragePolicy
    {
        public CoveragePolicy(string id, string lastName, string firstName, char gender, string dateOfBirth, string company, string policyNumber, int coverage, string issueDate, string issueState, decimal faceAmount, decimal premiumAmount, decimal cashValue)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            Company = company;
            PolicyNumber = policyNumber;
            Coverage = coverage;
            IssueDate = issueDate;
            IssueState = issueState;
            FaceAmount = faceAmount;
            PremiumAmount = premiumAmount;
            CashValue = cashValue;
        }

        public string Id { get; set; }
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public char Gender { get; set; }

        public string DateOfBirth { get; set; }
        public string Company { get; set; }

        public string PolicyNumber { get; set; }
        public int Coverage { get; set; }

        public string IssueDate { get; set; }

        public string IssueState { get; set; }
        
        public decimal FaceAmount { get; set; }

        public decimal PremiumAmount { get; set; }

        public decimal CashValue { get; set; }

        //DateOfBirth,Company,PolicyNumber,Coverage,IssueDate,IssueState,FaceAmount,PremiumAmount,CashValue
    }
}
