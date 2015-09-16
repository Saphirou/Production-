using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarsztatMalina
{
    [Serializable]
    public class DaneLog
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public DaneLog(string n, string p)
        {
            this.Name = n;
            this.Password = p;
        }
        public override string ToString()
        {
            return "Nazwa: " + this.Name+" Hasło: "+this.Password;
        }
        
    }


    
}
