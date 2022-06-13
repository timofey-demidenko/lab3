using System;
using System.Text;
using static System.Console;

namespace Program
{
    internal class lab3
    {

        static int Avarege(int x, int y)
        {
            int result = 0;
            while (x < y)
            {
                result *= x;
                x++;
            }
            return result;
        }

        static bool Fibonacci(int number)
        {
            int n1 = 0, n2 = 1, n3, i = 2, x = 0;
            while (number > i)
            {
                n3 = n1 + n2;
                //Write(n3 + " ");
                n1 = n2;
                n2 = n3;
                i++;
                if (i >= number)
                    x = number;
            }
            if (number == x)
                return true;
            else
                return false;
        }
        static void Main()
        {
            ///////////////////////////////////////////#1

            /* int a = int.Parse(ReadLine());
            int b = int.Parse(ReadLine());
            WriteLine(Avarege(a, b)); */

            ///////////////////////////////////////////#2

            /* int number = int.Parse(ReadLine());
            WriteLine(Fibonacci(number)); */

            ///////////////////////////////////////////#3

            /* int[] numbers2 = new int[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
                numbers2[i] = rand.Next(0, 100);
            foreach (int a in numbers2)
                WriteLine(a);
            WriteLine();

            Array.Sort(numbers2);
            foreach (int a in numbers2)
                WriteLine(a); */

        }
    }
    internal class City
    {
        private string nameCity = "";
        private string nameCountry = "";
        private int persons = 0;
        private string kodeNumber = "";
        private string namesCities = "";

        City(string nameCity, string nameCountry, int persons, string kodeNumber, string namesCities)
        {
            this.nameCity = nameCity;
            this.nameCountry = nameCountry;
            this.persons = persons;
            this.kodeNumber = kodeNumber;
            this.namesCities = namesCities;
        }
        public string NameCity { get { return nameCity; } }
        public string NameCountry { get { return nameCountry; } }
        public int Persons { get { return persons; } }
        public string KodeNumber { get { return kodeNumber; } }
        public string NamesCities { get { return namesCities; } }

    }
    internal class Kollega
    {
        private string fullName = "";
        private string birthDate = "";
        private string phoneNumber = "";
        private string email = "";
        private string state = "";
        private string working = "";

        Kollega(string fullName, string birthDate, string phoneNumber, string email, string state, string working)
        {
            this.fullName = fullName;
            this.birthDate = birthDate;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.state = state;
            this.working = working;
        }

        public string FullName { get { return fullName; } }
        public string BirthDate { get { return birthDate; } }
        public string PhoneNumber { get { return phoneNumber; } }
        public string Email { get { return email; } }
        public string State { get { return state; } }
        public string Working { get { return working; } }

    }

    internal class Plane
    {
        private string names = "";
        private string prod = "";
        private string date = "";
        private string type = "";

        Plane(string names, string prod, string date, string type)
        {
            this.names = names;
            this.prod = prod;
            this.date = date;
            this.type = type;
        }

        public string Name { get { return names; } }
        public string Prod { get { return prod; } }
        public string Date { get { return date; } }
        public string Type { get { return type; } }
    }
    internal class Matrix
    {
        private int height = 0;
        private int widht = 0;
        private int max = 0;
        private int min = 0;

        Matrix(int height, int widht)
        {
            this.height = height;
            this.widht = widht;
        }

        static int MAX_MIN(int max, int[,] array)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array.Length; j++)
                    if (array[i, j] > max) max = array[i, j];
            return max;

        }
        static int MAX_MIN(int max, int min, int[,] array)
        {
            min = MAX_MIN(max, array);
            for (int i = 0; i < array.Length; i++)
                for (int j = 0; j < array.Length; j++)
                    if (array[i, j] < min) min = array[i, j];

            return min;
        }

    }

}