using System;
namespace Alliance.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;

        public string MiddleName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public int Age { get; set; } = 0;

        public string Sex { get; set; } = string.Empty;
        
        public string CivilStatus { get; set; } = string.Empty;

        public string Birthday { get; set; } = string.Empty;

        public string ContactNumber { get; set; } = string.Empty;

        public string EmailAddress { get; set; } = string.Empty;

        public string ContractType { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;

        public string DateJoined { get; set; } = string.Empty;



    }
}

