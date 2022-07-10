
// Ability to create a Contacts in Address Book with first and last names,
// address,city, state, zip, phone number and email...

public class AddressBook
{
    string cityname;
    string state;
    double zipcode;
    long phoneNo;
    string email_id;
    void name(string firstname,string lastname) 
    { 
        string fullname = firstname+ " " + lastname;


        Console.WriteLine("Your firstname is:- :" + firstname);
        Console.WriteLine("Your lastname  is:-  :" + lastname);
        Console.WriteLine("Your fullname  is:-  :" + fullname);


    }
    
    public static void Main()
    {
        AddressBook add = new AddressBook();
        add.name("Nitish", "Mehta");

        add.cityname = "Bangalore";
        add.state = "karnataka";
        add.zipcode = 560068;
        add.phoneNo = 8252669501;
        add.email_id = "nkrmehta09@gmail.com";


              Console.WriteLine("cityname is :-" +add.cityname);
              Console.WriteLine("state    is :-" + add.state);
              Console.WriteLine("zipcode  is :-" + add.zipcode);
              Console.WriteLine("phoneNo  is :-" + add.phoneNo);
              Console.WriteLine("email_id  is :-" + add.email_id);
        }
} 