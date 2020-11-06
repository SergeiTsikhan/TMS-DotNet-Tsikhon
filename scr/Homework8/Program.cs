using Microsoft.VisualBasic;
using System;

/// <summary>
/// Bankomat app.
/// </summary>

namespace Homework8
{
    class Client
    {

        delegate void SayMessage(decimal a);
       
        SayMessage _del;
        public decimal _sum = 0;
        public decimal _sum2 = 0;
        public string _name;
        public int _password;
        public Guid _id;

        public Client(decimal sum, decimal sum2, string name, int password)
        {
            _id = Guid.NewGuid();
            _sum = sum;
            _sum2 = sum2;
            _name = name;
            _password = password;
            _sum2 = sum2;
        }

        public Client()
        {
        }


        public decimal getSum(decimal sum)
        {
            return sum;
        }
        public decimal getSum2(decimal sum2)
        {
            return sum2;
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Name = value;
            }
        }


        public void putMoney(decimal sum)
        {
            _sum += sum;
            _del = InformationPut;
            _del(sum);
        }

        public void withdrawMoney(decimal sum)
        {
            if (_sum >= sum)
            {
                _sum -= sum;
                _del = InformationWithdraw;
                _del(sum);
            }
            else
            {
                _del = InformationWithdraw1;
                _del(sum);
            }
        }
        public void InformationWithdraw(decimal sum)
        {
            Console.WriteLine($"You take {sum}");
        }
        public void InformationWithdraw1(decimal sum)
        {
            Console.WriteLine($"Not Enough money");
        }

        public void InformationPut(decimal sum)
        {
            Console.WriteLine($"You put {sum}");
        }
        public void ShowInfo()
        {
            Console.WriteLine($"{_id}");
            Console.WriteLine($"{_sum}");
            Console.WriteLine($"{_name}");
            Console.WriteLine($"{_password}");
            Console.WriteLine($"{_sum2}");
        }

    }
   class Program
    {
        static void Main(string[] args)
        {
            var newclient = new Client(100M, 200M, "Petrov", 1234);
            newclient.withdrawMoney(100);
            newclient.withdrawMoney(100);
            newclient.putMoney(100);
            newclient.withdrawMoney(100);
            newclient.withdrawMoney(100);
            newclient.withdrawMoney(100);
            newclient.ShowInfo();
        }


    }
}
