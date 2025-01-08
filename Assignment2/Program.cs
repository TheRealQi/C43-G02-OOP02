namespace Assignment2
{
    #region 1.1 -Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data.

    struct Person
    {
        public string Name;
        public int Age;
    }

    #endregion

    #region 1.2 - Create a struct called "Point" to represent a 2D point with properties "X" and   "Y".

    struct Point
    {
        public int X;
        public int Y;
    }

    #endregion


    #region 1.4 - Create a struct named Rectangle that represents a rectangle with the following fields:

    // width (type: double)
    // height (type: double)
    // Implement encapsulation by making the fields private and provide public properties  access and modify these values. Ensure the following conditions are met:
    // The width and height should not be negative. If a negative value is provided, the setter should not update the field and should instead print an error message.
    // Implement a public read-only property Area that calculates and returns the area of the rectangle (Area = width * height).
    // Implement a method DisplayInfo that prints the rectangle's dimensions and area.


    struct Rectangle
    {
        private double width;
        private double height;

        public double Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Width cannot be negative");
                }
                else
                {
                    width = value;
                }
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Height cannot be negative");
                }
                else
                {
                    height = value;
                }
            }
        }

        public double Area()
        {
            return width * height;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Width: " + width);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Area: " + Area());
        }
    }

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.2 - Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            
            Person[] people1 =
            {
                new Person { Name = "Mohamed", Age = 23 },
                new Person { Name = "Ahmed", Age = 21 },
                new Person { Name = "Osama", Age = 25 }
            };
            
            for (int i = 0; i < people1.Length; i++)
            {
                Console.WriteLine("Name: " + people1[i].Name);
                Console.WriteLine("Age: " + people1[i].Age);
                Console.WriteLine();
            }
            
            #endregion
            
            #region 2.2 - Write a C# program that takes two points as input from the user and calculates the distance between them.
            
            Console.WriteLine("Enter the first point x1 and y1 seperated by a space: ");
            Point p1 = new Point();
            string[] point1 = Console.ReadLine().Split(' ');
            p1.X = int.Parse(point1[0]);
            p1.Y = int.Parse(point1[1]);
            
            Console.WriteLine("Enter the second point (x2, y2): ");
            Point p2 = new Point();
            string[] point2 = Console.ReadLine().Split(' ');
            p2.X = int.Parse(point2[0]);
            p2.Y = int.Parse(point2[1]);
            
            double distance = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
            Console.WriteLine(distance);
            
            #endregion

            #region 3.2 - Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            Person[] people3 = new Person[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nEnter details for person {i + 1}:");
                people3[i] = new Person();
                Console.Write("Name: ");
                people3[i].Name = Console.ReadLine();
                Console.Write("Age: ");
                people3[i].Age = Convert.ToInt32(Console.ReadLine());
            }
            
            Person oldest = people3[0];
            for (int i = 1; i < 3; i++)
            {
                if (people3[i].Age > oldest.Age)
                {
                    oldest = people3[i];
                }
            }
            
            Console.WriteLine($"Oldest person: \nName: {oldest.Name}\nAge: {oldest.Age}");

            #endregion

            #region 4.2 - Write a program to demonstrate the usage of this struct by creating an instance, setting values via properties, and displaying the area.
            
            Rectangle rect = new Rectangle();
            rect.Height = 10;
            rect.Width = 5;
            Console.WriteLine("Area: " + rect.Area());
            rect.DisplayInfo();

            rect.Width = -5;
            rect.Height = -10;

            #endregion
        }
    }
}