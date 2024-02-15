using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        int spl = 5098;
        List<string> cust = new List<string>(){"Ashwin", "Bumrah", "Shami", "Kohli", "jadeja"};
        List<uint> money = new List<uint>{20000, 35000, 58000, 24000, 35000};
        Console.WriteLine("Enter your name to to check if you are our customer");
        string name = Console.ReadLine();
        for (int i = 0; i < cust.Count; i++)
        {
            if(name==cust[i])
            {
                Console.WriteLine("Enter the Key to CHeck if you are special Member");
                int special_key = Convert.ToInt32(Console.ReadLine());
                if(special_key==spl)
                {
                    Console.WriteLine("You are our primium customer.\n Press 1. To Deposit. \n Press 2. To Withdraw. \n Press 3. To Check Balance. \n Press 1. To Delete Account.");
                    int value = Convert.ToInt32(Console.ReadLine());
                    switch(value)
                    {
                        case 1:
                            Console.WriteLine("The Amount available in you account is {0} \n Enter the Amount to To Deposit", money[i]);
                            uint w = Convert.ToUInt32(Console.ReadLine());
                            money[i] += (w + (w/100)*6);
                            Console.WriteLine("he total balance is: {0}",money[i]);
                            break;
                        case 2:
                            Console.WriteLine("The Amount available in you account is {0} \n Enter the Amount to To Withdraw", money[i]);
                            w = Convert.ToUInt32(Console.ReadLine());
                            money[i] += (w - (w/100)*1);
                            Console.WriteLine("he total balance is: {0}",money[i]);
                            break;
                        case 3:
                            Console.WriteLine("The available balance in your account is: {0} \n \n THank you for Banking with us", money[i]);
                            break;
                        case 4:
                            cust.RemoveAt(i);
                            money.RemoveAt(i);
                            Console.WriteLine("THank you for Banking with us");
                            break;
                        default:
                            break;
                    
                    }
                }
                else
                {
                    Console.WriteLine("Sorry! You are not a Special Customer.\n Press 1. To Deposit. \n Press 2. To Withdraw. \n Press 3. To Check Balance. \n Press 1. To Delete Account.");
                    int value = Convert.ToInt32(Console.ReadLine());
                    switch(value)
                    {
                        case 1:
                            Console.WriteLine("The Amount available in you account is {0} \n Enter the Amount to To Deposit", money[i]);
                            uint w = Convert.ToUInt32(Console.ReadLine());
                            money[i] += (w + (w/100)*3);
                            Console.WriteLine("he total balance is: {0}",money[i]);
                            break;
                        case 2:
                            Console.WriteLine("The Amount available in you account is {0} \n Enter the Amount to To Withdraw", money[i]);
                            w = Convert.ToUInt32(Console.ReadLine());
                            money[i] += (w - (w/100)*2);
                            Console.WriteLine("he total balance is: {0}",money[i]);
                            break;
                        case 3:
                            Console.WriteLine("The available balance in your account is: {0} \n \n THank you for Banking with us", money[i]);
                            break;
                        case 4:
                            cust.RemoveAt(i);
                            money.RemoveAt(i);
                            Console.WriteLine("THank you for Banking with us");
                            break;
                        default:
                            break;
                    
                    }
                }

            }
            else
            {
                Console.WriteLine("You dont have an account with us.\nplease enter your name to open a new Account");
                string name1= Console.ReadLine();
                cust.Add(name1);
                Console.WriteLine("ENter the Amount you want to Deposit");
                uint q = Convert.ToUInt32(Console.ReadLine());
                money.Add(q);
                Console.WriteLine("Congratulations! Your Account has been Created");
                break;
            }
            break;
        }
        Console.ReadLine();
        
    }
    
}