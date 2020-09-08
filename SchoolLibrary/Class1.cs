using System;
using System.Text;

namespace SchoolLibrary
{
    public class Class1
    {
        
        public string Name { get; set; } // uses encapsulation
        public string SchoolAddress { get; set; }
        public string SchoolCity { get; set; }
        public string SchoolState { get; set; }
        public string SchoolZip { get; set; }
        public string PhoneNumber { get; set; }
        private string _twitterAddress;
        public string TwitterAddress
        {
            // starts with @
            get { return _twitterAddress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                } else
                {
                    throw new Exception("Your twitter address must begin with an @");
                }
            }

        }
        // constructor 
        public Class1()
        {
            Name = "Rhodes Park High School";
            PhoneNumber = "555-5678-989";
            SchoolCity = "Portland";
        }
        // overloaded constructor 
        public Class1(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;
        }
        // Methods functions 
        //public float AverageThreeScores(float a, float b, float c)
        //{
        //    var result = a + b + c / 3;
        //    return result;
        //}

        public float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;

        public int AverageThreeScores(int a, int b, int c)
        {
            var result = a + b + c / 3;
            return result;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.Name);
            sb.AppendLine(this.SchoolAddress);
            sb.AppendLine(this.SchoolCity);
            sb.Append(", ");
            sb.Append(this.SchoolState);
            sb.Append(", ");
            sb.Append(this.SchoolZip);
            return sb.ToString();
        }
    }
}
