
using OOP;

int subOption;
int option;
string ans = string.Empty;
Customer[] customers = new Customer[100];

do
{

    Console.Clear();
    Console.WriteLine("******************************************");
    Console.WriteLine("Welcome To MeriteFi Core Banking Platform");
    Console.WriteLine("******************************************");
    Console.WriteLine();
    Console.Beep();
    Console.WriteLine("Please Select an Option:");
    Console.WriteLine();

    Console.WriteLine("1. Manage Customers");
    Console.WriteLine("2. Manage Accounts");
    Console.WriteLine("3. Exit Application");
    Console.WriteLine();

    Console.Write("Option: ");
    option = Convert.ToInt32(Console.ReadLine());

    if (option == 1)
    {
        do
        {

            Console.Beep();
            Console.WriteLine();
            Console.WriteLine("Please select a Customer Management Option:");
            Console.WriteLine();

            Console.WriteLine("1.  Create Customers");
            Console.WriteLine("2.  Update Customers");
            Console.WriteLine("3.  Delete Customers");
            Console.WriteLine("4.  List Of Customers");
            Console.WriteLine("5.  Find Customer");
            Console.WriteLine("6.  Find Customer by ID");
            Console.WriteLine("7.  Find Customer By Code");
            Console.WriteLine("8.  Go Back To Previous Menu");

            Console.WriteLine();
            Console.Write("Option: ");
            subOption = Convert.ToInt32(Console.ReadLine());

            switch (subOption)
            {
                case 1:

                    Customer customer = new Customer();
                    Console.WriteLine("1.  Create Customers");
                    Console.WriteLine();
                    Console.WriteLine("Input Custormer Details");
                    Console.WriteLine();

                    Console.Write("First Name: ");
                    customer.FirstName = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Last Name: ");
                    customer.LastName = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Middle Name: ");
                    customer.MiddleName = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Gender: Male(M) or Female(F)");
                    string gender = Console.ReadLine();
                    if (gender.ToLower() == "male" || gender.ToLower() == "m")
                    {
                        customer.Gender = "Male";
                    }
                    else if (gender.ToLower() == "female" || gender.ToLower() == "f")
                    {
                        customer.Gender = "Female";
                    }
                    Console.WriteLine();

                    Console.Write("National Identification Number(NIN): ");
                    customer.Nin = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Bank Verification Number(BVN): ");
                    customer.Bvn = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Address: ");
                    customer.Address = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Country: ");
                    customer.Country = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("State of Origin: ");
                    customer.StateOfOrigin = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Date of Birth: ");
                    customer.Dob = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Phone Number: ");
                    customer.PhoneNumber = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("E-mail Address: ");
                    customer.Email = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Account Type: Current(C) or Savings(S)");
                    string accountType = Console.ReadLine();
                    if (accountType.ToLower() == "Current" || accountType.ToLower() == "c")
                    {
                        customer.CustomerType = "Current";
                    }
                    else if (accountType.ToLower() == "Savings" || accountType.ToLower() == "S")
                    {
                        customer.CustomerType = "Savings";
                    }
                    Console.WriteLine();

                    Console.Write("Next of kin Name: ");
                    customer.NokName = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Next of kin Address: ");
                    customer.NokAddress = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Next of Kin Phone Number: ");
                    customer.NokPhone = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Next of Kin E-mail Address: ");
                    customer.NokEmail = Console.ReadLine();
                    Console.WriteLine();

                    Console.Write("Next of KinRelationship: ");
                    customer.NokRelationshipType = Console.ReadLine();
                    Console.WriteLine();

                    for (int i = 0; i <= customers.Length; i++)
                    {
                        if (customers[i] == null)
                        {
                            customer.Code = Convert.ToString(i + 1).PadLeft(3, '0');

                            customers[i] = customer;
                        }
                        
                    }


                    break;

                case 2:

                    Console.WriteLine("2.  Update Customers");
                    Console.ReadLine();

                    break;

                case 3:

                    Console.WriteLine("3.  Delete Customers");
                    Console.ReadLine();

                    break;

                case 4:

                    Console.WriteLine("4.  List Of Customers");
                    Console.ReadLine();

                    break;

                case 5:

                    Console.WriteLine("5.  Find Customer");
                    Console.ReadLine();

                    break;

                case 6:

                    Console.WriteLine("6.  Find Customer by ID");
                    Console.ReadLine();

                    break;

                case 7:

                    Console.WriteLine("7.  Find Customer By Code");
                    Console.ReadLine();

                    break;
                case 8:
                    subOption = 8;

                    break;

            }

        }
        while (subOption != 8);


    }
    else if (option == 2)
    {

        Console.Beep();
        Console.WriteLine();
        Console.WriteLine("Please Select an Option:");
        Console.WriteLine();

        Console.WriteLine("1.  Create Accounts");
        Console.WriteLine("2.  Update Accounts");
        Console.WriteLine("3.  Delete Accounts");
        Console.WriteLine("4.  List Of Accounts");
        Console.WriteLine("5.  Find Account");
        Console.WriteLine("6.  Find Account by Number");
        Console.WriteLine("7.  Find Account By Code");
        Console.WriteLine("8.  Go Back To Previous Menu");

        Console.WriteLine();
        Console.Write("Option: ");
        subOption = Convert.ToInt32(Console.ReadLine());

        switch (subOption)
        {
            case 1:
                Account account = new Account();
                break;

            case 2:

                break;

            case 3:

                break;

            case 4:

                break;

            case 5:

                break;

            case 6:

                break;

            case 7:

                break;
            case 8:

                break;

        }


    }
    else
    {
        ans = "yes";
    }


    Console.Beep();
    Console.Write("Do you want to continue: ");
    ans = Console.ReadLine();
}
while (ans.ToLower() == "yes" || ans.ToLower() == "y");





