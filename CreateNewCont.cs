using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNine_AddressBook
{
    public class CreateNewCont
    {
        string cityname;
        string state;
        double zipcode;
        long phoneNo;
        string email_id;
        void name(string firstname, string lastname)
        {
            string fullname = firstname + " " + lastname;


            Console.WriteLine("Your firstname is:- :" + firstname);
            Console.WriteLine("Your lastname  is:-  :" + lastname);
            Console.WriteLine("Your fullname  is:-  :" + fullname);


        }
        
        public static void Main()
        {
            CreateNewCont add = new CreateNewCont();
            CreateNewCont newcontact = new CreateNewCont();

            add.name("Nitish", "Mehta");

            add.cityname = "Bangalore";
            add.state = "karnataka";
            add.zipcode = 560068;
            add.phoneNo = 8252669501;
            add.email_id = "nkrmehta09@gmail.com";


            Console.WriteLine("cityname is :-" + add.cityname);
            Console.WriteLine("state    is :-" + add.state);
            Console.WriteLine("zipcode  is :-" + add.zipcode);
            Console.WriteLine("phoneNo  is :-" + add.phoneNo);
            Console.WriteLine("email_id  is :-" + add.email_id);
        }
    }
}
}
