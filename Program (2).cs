namespace ConvertProject
{
    class Convert
    {
        private double usd, eur, rub;
        public Convert(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public double ToUsd(double uah)
        {
            return uah / usd;
        }

        public double ToEur(double uah)
        {
            return uah / eur;
        }

        public double ToRub(double uah)
        {
            return uah / rub;
        }

        public double FromUsd(double usd)
        {
            return usd * this.usd;
        }

        public double FromEur(double eur)
        {
            return eur * this.eur;
        }

        public double FromRub(double usd)
        {
            return usd * this.usd;
        }
    }

    class Program
    {
        static void Main()
        {
            Convert convert = new Convert(36.9, 36.94, 0.61);
            Console.WriteLine("1. UAH -> USD / EUR / RUB");
            Console.WriteLine("2. USD / EUR / RUB -> UAH");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.Write("Money(UAH): ");
                double uah = double.Parse(Console.ReadLine());
                Console.WriteLine("1. To USD");
                Console.WriteLine("2. To EUR");
                Console.WriteLine("3. To RUB");
                int s = int.Parse(Console.ReadLine());
                if (s == 1)
                    Console.WriteLine("$" + convert.ToUsd(uah));
                else if (s == 2)
                    Console.WriteLine("€" + convert.ToEur(uah));
                else
                    Console.WriteLine(convert.ToRub(uah));
            }
            else
            {
                Console.WriteLine("1. From USD");
                Console.WriteLine("2. From EUR");
                Console.WriteLine("3. From RUB");
                int s = int.Parse(Console.ReadLine());
                Console.Write("Money amount: ");
                double m = double.Parse(Console.ReadLine());
                if (s == 1)
                    Console.WriteLine(convert.FromUsd(m) + "₴");
                else if (s == 2)
                    Console.WriteLine(convert.FromEur(m) + "₴");
                else
                    Console.WriteLine(convert.FromRub(m) + "₴");
            }

        }
    }
}
