using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_GUI
{
    class Member
    {
        public Member(string name, string e_mail, string date, int durration)
        {
            this.name = name;
            this.e_mail = e_mail;
            this.date = date;
            this.durration = durration;
        }
        public string name { get; set; }
        public string e_mail { get; set; }
        public string date { get; set; }
        public int durration { get; set; }
    }
}
