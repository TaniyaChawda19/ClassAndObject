using System.Diagnostics.CodeAnalysis;
using static System.Formats.Asn1.AsnWriter;

namespace ClassAndObject
{
    

    public class CreditCard  //Question 1
    {
        static void Main(string[] args)
        {

            float payment;
            float debt;
            int month;

            Console.WriteLine("Please enter the monthly payment");
            payment = int.Parse(Console.ReadLine());
            month = 0;
            debt = 1000;


            while (debt > payment)
            {
                debt = (float)(debt * 1.015);
                debt = debt - payment;
                Console.WriteLine("Month: " + (month = month + 1) + "   Balance: " + debt + "      Total payements : " + (payment * month));
            }
            Console.WriteLine("Month: " + (month = month + 1) + "   Balance: $0.0" + "      	       Total payed: $" + (payment * month - debt));
        }
    }
/*-----------------------------------------------------------------------------------------------------------------------------------------*/
    class Account
    {
        int Account_Number;
        string customer_Name;
        string account_type;
        int amount;
        int balance;

        int credit(int amt,int bal)
        {
            bal += amt;
                return bal;
        }

        int debit(int amt,int bal)
        {
            bal -= amt;
            return bal;
        }
        public void Accept(int Account_Number, string customer_Name,string account_type, int amount, int balance)
        {
            this.Account_Number = Account_Number;
            this.customer_Name= customer_Name; 
            this.account_type= account_type;
            this.amount = amount;
            this.balance = balance;
            int nw_balance;
            if (account_type=="Deposit")
            {
                nw_balance=credit(amount, balance);
                    
            }
            else
            {
                nw_balance=debit(amount, balance);
            }
            Console.WriteLine("Account_Number : " + Account_Number);
            Console.WriteLine("Cusotomer Name : " + customer_Name);
            Console.WriteLine("Account type : " + account_type);
            Console.WriteLine("Amount : " + amount);
            Console.WriteLine("Balance : " + nw_balance);

        }

        
    }
    class Ques2
    {
        static void Main(string[] args)
        {
            var ob = new Account();
            ob.Accept(12220023, "Taniya Chawda", "Deposit", 200, 5000);
        }
    }
/*------------------------------------------------------------------------------------------------------------------------*/
    public class Student
    {
        int rollno;
        string name;
        int cl;//class
        int sem;
        string branch;
        int[] mark = new int[5];

        public Student(int rollno,string name,int cl,int sem,string branch, int[] mark)
        {
            this.rollno = rollno;   
            this.name = name;
            this.cl = cl;
            this.sem = sem;
            this.branch = branch;
            this.mark = mark;

            Console.WriteLine("Roll Number : " + rollno);
            Console.WriteLine("Name : "+ name);
            Console.WriteLine("Class : " + cl);
            Console.WriteLine("Semester : " + sem);
            Console.WriteLine("Branch : " + branch);
            Console.Write("Marks : ");
            foreach (int val in mark)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine("");
            display_result(mark);
        }
         
        public void display_result (int[] mark)
        {
            int sum = 0;
            int flag = 1;

            foreach(int val in mark)
            {
                sum += val;
                if(val<35)
                {
                    flag = 0;
                    break;
                }
            }
            float avg=(float)sum/5;

            Console.WriteLine("Average : " + avg);
            Console.Write("Result : ");

            if(flag==1 && avg<50)
            {
                Console.WriteLine("Failed");
            }
            else if(flag==1 && avg>50)
                {
                Console.WriteLine("Passed");
            }
            else if(flag==0)
            {
                Console.WriteLine("Failed");
            }
        }





    }
    class Ques3
    {
        static void Main()
        {
            int[] mark = { 37, 38, 39, 40, 41 };
            var ob = new Student(123, "Taniya chawda", 5, 3, "CSE", mark);

        }
    }

/*----------------------------------------------------------------------------------------------------------------------------------------*/
    class Book
    {
        public int isbn;
        public string name;
        public string title;
        public string author;
        public int quantity;
        public int price;
        
        public void Show()
        {
            Console.WriteLine($"isbn : {isbn}" + $"Book Name : {name}" + $" Title : {title}" + $" Author : {author}" + $" Quantity : {quantity}" + $" price : {price}");
        }

        public int total(int quantity, int price)
        {
            return quantity * price;
        }


    }

    class Ques5
    {
        static void Main(string[] args)
        {
            Book [] b = new Book[3];
            b[0] = new Book();
            b[0].isbn = 1;
            b[0].name = "A";
            b[0].title = "B";
            b[0].author = "C";
            b[0].quantity = 50;
            b[0].price = 100;

            b[0].Show();

            b[1] = new Book();
            b[1].isbn = 2;
            b[1].name = "D";
            b[1].title = "E";
            b[1].author = "F";
            b[1].quantity = 10;
            b[1].price = 150;

            b[1].Show();

            b[2] = new Book();
            b[2].isbn = 3;
            b[2].name = "G";
            b[2].title = "H";
            b[2].author = "I";
            b[2].quantity = 15;
            b[2].price = 200;

            b[2].Show();

            int sum = 0;
            for(int i=0;i<3;i++)
            {
                sum += b[i].quantity* b[i].price;
            }
            Console.WriteLine("Total Price : " + sum);
        }



    }
/*----------------------------------------------------------------------------------------------------------------------------------------*/
    class Shapes
    {
                public double Area(double r)
        {
            return 3.14 * r * r;
        }
        public int Area(int a,int b)
        {
            return a * b;
        }

        public int Area(int a)
        {
            return a * a;
        }
        public double Area(int a,int b, int c)
        {
         var  sp = (a + b + c) / 2;
            return (double)(Math.Sqrt(sp*(sp - a)*(sp - b)*(sp - c)));
        }
    }

    class Ques6
    {
        static void Main(string[] args)
        {
            var ob = new Shapes();
            Console.WriteLine("Area of circle with radius 2.5 : " + ob.Area(2.5));
            Console.WriteLine("Area of Square with side 3 : " + ob.Area(3));
            Console.WriteLine("Area of Rectangle with lenght=10 and breadth=15: " + ob.Area(10, 15));
            Console.WriteLine("Area of triangle with sides 3,4 and 5 : " + ob.Area(3, 4, 5));

        }
    }

    /*-----------------------------------------------------------------------------------------------------------------*/





    class Bank //Question  7
    {
        public string name;
        public int acc_number;
        public int type;
        public int balance;


        public void assign(string name, int acc_number, int type, int balance)
        {
            this.name = name;
            this.acc_number = acc_number;
            this.type = type;
            this.balance = balance;
        }
        public int deposit(int amt)
        {
            return balance += amt;
        }
        public int draw(int wamt)
        {
            if (balance >= wamt)
            {
               balance -= wamt;
                return balance;
            }
            else
            {
                return -99999999;
            }
        }
         public void display()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Balance : " + balance);
        }


    }

/*---------------------------------------------------------------------------------------------------------------------------------*/

class Student2
{
    public int rollno;
    public string name;
    public int markinEng;
    public int markinMath;
    public int markinScience;

    
    public void Total( int a,int b ,int c)
    {
        Console.WriteLine("Total marks : "+( a+b+c));
    }
}

class Ques8
{
    static void Main(string[] args)
    {
        var s = new Student2();
        s.rollno = 1;
        s.name = "A";
        s.markinEng = 90;
        s.markinMath = 80;
        s.markinScience = 96;

        s.Total(s.markinMath, s.markinEng, s.markinScience);

    }
    
    
}
}