using System;


namespace firstdemo
{
   class Program
    {
        string name = "Fazal";
        int roll_no=15;
        string subject = "Java";

        void student()
        {
            Console.WriteLine($" The name of Student is {name} and his roll number is {roll_no} and he is a student of {subject}");
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World \n");
            //string x = "hello", y = "fazal";
            //Console.WriteLine(x + y);
            //Console.Read();
            Program p1= new Program();
            p1.student();
            Console.Read();
        }
    }
}
