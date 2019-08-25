using System;
using System.Collections.Generic;


namespace Phbook
{
    public class People
    {
        public String name { get; set; }

        public String email { get; set; }

        public String contact { get; set; }

        public String city { get; set; }

        public People(String name, String email, String contact, String city)
        {
            this.name = name;
            this.email = email;
            this.contact = contact;
            this.city = city;
        }
    }


    public class Phonebook
    {
        List<People> list = new List<People>();
        List<People> result=new List<People>();
        public Phonebook()
        {
            list.Add(new People("gunjan", "gd@gmail.com", "8401174077", "Dhoraji"));
            list.Add(new People("krinish", "kr@gmail.com", "8401174011", "Dhoraji"));
            list.Add(new People("rutvik", "rk@gmail.com", "8401174000", "Rajkot"));
        }

        public List<People> this[String name]
        {
            get
            {
                result.Clear();
                foreach (People p in list)
                {
                    if (p.name == name)
                    {
                        result.Add(p);
                    }
                }
                return result;
            }
        }

        public List<People> this[String name, String city]
        {
            get
            {
                result.Clear();
                foreach (People p in list)
                {
                    if (p.name == name && p.city == city)
                    {
                        result.Add(p);
                    }
                }
                return result;
            }
        }

        public List<People> this[Boolean flag]
        {
            get
            {
                if (flag == true)
                {
                    return list;
                }
                else
                {
                    return null;
                }
            }
        }


    }
}