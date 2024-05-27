/*
void DisplayRandomNumbers() 
{
    Random random = new Random();
    for (int i = 0; i < 5; i++) 
    {
        Console.Write($"{random.Next(1, 100)} ");
    }
    Console.WriteLine();
}

DisplayRandomNumbers();


*/
/*
using System;

int[] times = {800, 1200, 1600, 2000};
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");

/* Format and display medicine times */

/*
DisplayTimes();


Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

    /* Adjust the times by adding the difference, keeping the value within 24 hours */

/*
    AdjustTimes();
} 
else 
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

    /* Adjust the times by adding the difference, keeping the value within 24 hours */
/*
AdjustTimes();
}

Console.WriteLine("New Medicine Schedule:");
/* Format and display medicine times */
/*
DisplayTimes();



//-----------------------------------------------NEW CODE----------------------------------------------------------//

void DisplayTimes() 
{
    
    foreach (int val in times)
    {
        string time = val.ToString();
        int len = time.Length;

        if (len >= 3)
        {
            time = time.Insert(len - 2, ":");
        }
        else if (len == 2)
        {
            time = time.Insert(0, "0:");
        }
        else
        {
            time = time.Insert(0, "0:0");
        }

        Console.Write($"{time} ");
    }

    Console.WriteLine();
}


void AdjustTimes() 
{
  
    for (int i = 0; i < times.Length; i++) 
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}

*/

/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/

/*
string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;



foreach(string ip in ipv4Input)
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);
    ValidateLength();
    ValidateZeroes();
    ValidateRange();

    if (validLength && validZeroes && validRange)
        {
        Console.WriteLine($"ip is a valid IPv4 address");
        }
    else
        {
        Console.WriteLine($"ip is an invalid IPv4 address");
        }
}



void ValidateLength()
{
    validLength = address.Length == 4;
}
void ValidateZeroes()
{

    foreach (string number in address)
    {
        if (number.Length > 1 && number.StartsWith("0"))
        {
            validZeroes = false;
        }
    }
    validZeroes = true;
}
void ValidateRange()
{
    foreach (string number in address)
    {
        int value = int.Parse(number);
        if (value < 0 || value > 255)
        {
            validRange = false;
            return;
        }
    }
    validRange = true;

}

*/
/*
Random random = new Random();
int luck = random.Next(100);

string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

Console.WriteLine("A fortune teller whispers the following words:");
string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
for (int i = 0; i < 4; i++) 
{
    Console.Write($"{text[i]} {fortune[i]} ");
}

*/
/*
Random random = new Random();
int luck = random.Next(100);

string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};
TellFortune();
TellFortune();
luck = random.Next(100);
TellFortune();

void TellFortune() 
{
    Console.WriteLine("A fortune teller whispers the following words:");
    string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
    for (int i = 0; i < 4; i++) 
    {
        Console.Write($"{text[i]} {fortune[i]} ");
    }
}


*/

/*
void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
{
    int diff = 0;
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {
        Console.WriteLine("Invalid GMT");
    }

    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    }
    else
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }

    for (int i = 0; i < times.Length; i++) 
{
    int newTime = ((times[i] + diff)) % 2400;
    Console.WriteLine($"{times[i]} -> {newTime}");
}
}


int[] schedule = { 800, 1200, 1600, 2000 };
DisplayAdjustedTimes(schedule, 2, 12);

*/
/*
using System;

namespace MyApplication
{
  class Program
  {
    static int PlusMethod(int x, int y)
    {
      return x + y;
    }

    static double PlusMethod(double x, double y)
    {
      return x + y;
    }

    static void Main(string[] args)
    {
      int myNum1 = PlusMethodInt(8, 5);
      double myNum2 = PlusMethodDouble(4.3, 6.26);
      Console.WriteLine("Int: " + myNum1);
      Console.WriteLine("Double: " + myNum2);
    }  
  }
}

*/
/*
using System;
namespace MyApplication
{
    class Car
    {
        public string color = "red";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);
        }

    }
}

*/
/*
using System;
using Microsoft.VisualBasic;

namespace MyApplication
{
    class Car
    {
        public string? model;// the class member would not be accessible by other classes, unless i declare it public. 
        public string? color;
        public int? year;
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
        public string brake(string hard)
        {
            return "I will break: "+ hard;
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
            Opel.fullThrottle();
            Console.WriteLine(Ford.brake("easy"));
        }
    }
    
}

*/
/*
using System;
using Microsoft.VisualBasic;

namespace MyApplication
{
    class Car
    {
        public string model;
        public string color;
        public int year;

        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "Red", 1969);
            Car Audi = new Car("Audi", "Grey", 2017);
            Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.model);
            Console.WriteLine(Audi.color + " " + Audi.year + " " + Audi.model);
        }
    }
}

*/
/*
using System;

namespace MyApplication


{
    class Car
    {
        public static string model;
        public static string color;
        public static int year;

        // Static method to initialize the Car class
        public static void Initialize(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Call the static method to initialize the Car class
            Car.Initialize("Audi", "Grey", 19589);

            // Access the static fields directly
            Console.WriteLine(Car.color + " " + Car.year + " " + Car.model);
        }
    }
}

*/

/*
using System;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

namespace MyApplication
{
    class Car
    {
        private string model;

        public string Model
        {
            get{return model;} //get method
            set{model=value;} // set method 
        }

        public string color;
        public int year;

        public Car(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "Red", 1969);
            Car Audi = new Car("Audi", "Grey", 2017);
            Console.WriteLine(Ford.color + " " + Ford.year + " " + Ford.Model);
            //Console.WriteLine(Audi.color + " " + Audi.year + " " + Audi.model);
        }
    }
}


*/
/*

using System;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

namespace MyApplication
{
    class Vehicle
    //sealed class Vehicle would have generated an error as it would restrict from inheriting

    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }

    }
    class Car : Vehicle//Derived class
    {
        public string modelName = "Mustang";
    }

    class Program
    {

        static void Main(string[] args)
        {
            // Create a myCar object
            Car myCar = new Car();
            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        }
    }
}

*/


/*
using System;

namespace MyApplication
{
  class Animal  // Base class (parent) 
  {
    public virtual void animalSound()
    {
      Console.WriteLine("The animal makes a sound");
    }
  }

  class Pig : Animal  // Derived class (child) 
  {
    public override void animalSound()
    {
      Console.WriteLine("The pig says: wee wee");
    }
  }

  class Dog : Animal  // Derived class (child) 
  {
    public override void animalSound()
    {
      Console.WriteLine("The dog says: bow wow");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Animal myAnimal = new Animal();  // Create a Animal object
      Animal myPig = new Pig();  // Create a Pig object
      Animal myDog = new Dog();  // Create a Dog object
      
      myAnimal.animalSound();
      myPig.animalSound();
      myDog.animalSound();
    }
  }
}

*/
double total = 0;
double minimumSpend = 30.00;

double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

Console.WriteLine($"Total: ${total}");

double GetDiscountedPrice(int itemIndex)
{
    double result = items[itemIndex] * (1 - discounts[itemIndex]);
    return result;
}

void TotalMeetsMinimum()
{
    // Check if the total meets the minimum
}

void FormatDecimal(double input)
{
    // Format the double so only 2 decimal places are displayed
}