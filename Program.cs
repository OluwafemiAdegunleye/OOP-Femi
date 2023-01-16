

int option;
string ans = string.Empty;

do
{

    Console.Clear();
    Console.WriteLine("************************");
    Console.WriteLine("Welcome To MeriteFi Core");
    Console.WriteLine("************************");
    Console.WriteLine();
    Console.WriteLine("Please Select an Option:");
    Console.WriteLine();

    Console.WriteLine("1. Manage Customers");
    Console.WriteLine("2. Manage Accounts");
    Console.WriteLine();

    Console.Write("Option: ");
    option = Convert.ToInt32(Console.ReadLine());

    if (option == 1)
    {
        Console.WriteLine("1.  Create Customers");
        Console.WriteLine("2.  Update Customers");
        Console.WriteLine("3.  Delete Customers");
        Console.WriteLine("4.  List Of Customers");
        Console.WriteLine("5.  Find Customer");
        Console.WriteLine("6.  Find Customer by ID");
        Console.WriteLine("7.  Find Customer By Code");

    }
    else if (option == 2)
    {
        Console.WriteLine("1.  Create Accounts");
        Console.WriteLine("2.  Update Accounts");
        Console.WriteLine("3.  Delete Accounts");
        Console.WriteLine("4.  List Of Accounts");
        Console.WriteLine("5.  Find Account");
        Console.WriteLine("6.  Find Account by Number");
        Console.WriteLine("7.  Find Account By Code");

    }
    else
    {
        ans = "yes";
    }



    Console.Write("Do you want to continue: ");
    ans = Console.ReadLine();
}
while (ans.ToLower() == "yes" || ans.ToLower() == "y");



switch (option)
{
    case 1:

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

}


