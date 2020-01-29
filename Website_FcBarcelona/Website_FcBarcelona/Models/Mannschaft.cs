using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Website_FCBarcelona.Models
{
    public class Mannschaft
    {
            public int Number { get; set; }
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public DateTime Birthdate { get; set; }
            public decimal Salary { get; set; }
            public string Position { get; set; }

            public Mannschaft() : this(0, "", "", DateTime.MinValue, 0.0m, "") { }

            public Mannschaft(int number, string firstname, string lastname, DateTime birthdate, decimal salary, string position)
            {
                this.Number = number;
                this.Firstname = firstname;
                this.Lastname = lastname;
                this.Birthdate = birthdate;
                this.Salary = salary;
                this.Position = position;
            }

            // ToString ...

        }
    }
