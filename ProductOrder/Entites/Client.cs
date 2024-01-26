using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrder.Entites
{
    internal class Client
    {
        public string name { get; set; }
        public String email { get; set; }
        public DateTime birthDate { get; set; }

        public Client(string name, string email, DateTime birthDate)
        {
            this.name = name;
            this.email = email;
            this.birthDate = birthDate;
        }
        public override string ToString()
        {
            return "Client: " + name + "("+birthDate + ") - " + email;
        }
    }
}
