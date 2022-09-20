namespace AddressProject
{
    class Address
    {
        private string index;
        public string Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }

        private string country;
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }

        private string city;
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        private string street;
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }

        private int house;
        public int House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }

        private int apartment;
        public int Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Address address = new Address();
            address.Index = "123";
            address.Country = "Ukraine";
            address.City = "Kiyv";
            address.Street = "Shevchenko Street";
            address.House = 10;
            address.Apartment = 11;
            Console.WriteLine(address.Index + ", " + address.Country + ", " + address.City + ", " +
                              address.Street + " " + address.House + " / " + address.Apartment);
        }
    }
}
