// See https://aka.ms/new-console-template for more information
/*
Random dice = new ();
int roll1 = dice.Next(1, 7);
Console.WriteLine(roll1);
int roll2 = dice.Next(1, 7);
Console.WriteLine(roll2);
int roll3 = dice.Next(1, 7);
Console.WriteLine(roll3);
roll4 = dice.Next(1, 7);
Console.WriteLine(roll4);
Console.WriteLine(dice.Next(1, 7));


Random dice = new Random();
Double roll1 = dice.NextDouble();
int roll2 = dice.Next(101);
int roll3 = dice.Next();

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");


int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue,secondValue);

Console.WriteLine(largerValue);



Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if (total > 14)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}
*/
/*
string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}
*/
/*
Random dice = new Random();

//int roll1 = dice.Next(1, 7);
//int roll2 = dice.Next(1, 7);
//int roll3 = dice.Next(1, 7);
int roll1 = 5;
int roll2 = 5;
int roll3 = 4;
int total = roll1 + roll2 + roll3;
// the double line is a Boolean operator Or below 
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
// this is a boolean operator AND below 


if (total >= 15)
{
    Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
    Console.WriteLine("You win!");
}

else
{
    Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
    Console.WriteLine("Sorry, you lose.");
}


Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration==0)
    {
    Console.WriteLine("Your subscription expires within a day!");
    Console.WriteLine("Renew now and save 20%!");
    }
else if (daysUntilExpiration<2)
    {
    Console.WriteLine("Your subscription expires within a day!");
    Console.WriteLine("Renew now and save 20%!");
    }
else if (daysUntilExpiration<=5)
    {
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days");
    Console.WriteLine("Renew now and save 10%");
    }
else if (daysUntilExpiration <= 10)
    {
    Console.WriteLine("Your subscription will expire soon. Renew now!");
    }
*/
/*
Random random = new Random();

int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration==0)
    {
    Console.WriteLine("Your subscription has expired already !");
    }
else
    if (daysUntilExpiration<2)
    {
    discountPercentage = 20;
    Console.WriteLine("Your subscription expires within a day!");
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
    }
    else
        if (daysUntilExpiration<=5)
            {
            discountPercentage = 10;
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days");
            Console.WriteLine($"Renew now and save {discountPercentage}%!");
            }
        else
            if (daysUntilExpiration<=10)
                {
                Console.WriteLine("Your subscription will expire soon. Renew now!");
                }


string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"reassigned first value: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");



int[] scores={1,4,5};
Console.WriteLine(scores[0]);
Console.WriteLine(scores[1]);
Console.WriteLine(scores[2]+ 67.4);
*/

/*
using System.Globalization;
using System.Runtime.CompilerServices;

int[] numbers={1,6,90};
Console.WriteLine(numbers[0]);

string[] names = { "Rowena", "Robin", "Bao" };
foreach (var name in names) // could have used a string instead ofg a var to implicitly make sure it is a string . 
{
    Console.WriteLine(name);
}


int[] inventory = { 200, 450, 700, 175, 250 };
int sum=0;
foreach (int number in inventory)
    {
    Console.WriteLine(number);
    //sum=sum+ number;
    sum+=number;
    }
Console.WriteLine(sum);

Console.WriteLine($"The sum of money in inventory is {sum} roughly!");

*/


//int bin=0;
//Console.WriteLine(bin);
//bin++;// this is a short cut to bin = bin + 1
//Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");

/*
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin=0;

foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory.");



string[] orders={"B123","C234","A345","C15","B177","G3003","C235","B179"};


foreach (string order in orders)
    {
        //Console.WriteLine(order);
        if (order.StartsWith("B"))
            {
                Console.WriteLine($"The order {order} starts with 'B'!");
            }
    }

*/
/*

Random random = new Random();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}
// Print out each orderID
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}
*/

/* Boolean Expressions ---- Logic 
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");


string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());// trim gets rid of spaces in string and tolower is self explantory. 


Greater then > , Greater then or equal to >= , all same as python. 


string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));


Console.WriteLine(pangram.Contains("fox2") == false);
Console.WriteLine(!pangram.Contains("fox"));// logical negation reverses the condition. .. a bit like a NOT operator. in and or . 


//<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>


int saleAmount = 100;
//int discount = saleAmount > 1000 ? 100 : 50;
//Console.WriteLine($"Discount: {discount}");
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");


Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");

//METHOD 1 
Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");

//METHOD 2
/Method 2
Random coin = new Random();
Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");

*/
/*


string permission = "Admin|Manager";
int level = 20;
string message= (permission.Contains("Admin") && level>55)?"Welcome, Super Admin ":(permission.Contains("Admin")&&level<=55?"Welcome,Admin user":(permission.Contains("Manager")&&level>=20?"Contact an Admin for access":(permission.Contains("Manager")&&level<20?"You do not have sufficient privileges warning":(!permission.Contains("Manager")||!permission.Contains("Admin")?"You do not have sufficient privileges Final!!":"apparentlyour own of the manager or admin "))));
Console.WriteLine(message);

string permission="Manager";
int level=15;
//bool result=false;
Console.WriteLine(permission.Contains("Manager")||permission.Contains("Admin")?"you are either one but that does not matter":"YOU ARE restricited sorry ");




bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}


bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}
Console.WriteLine($"Outside the code block: {value}");




int value=5;

if (value>0)
    {
    int value2=6;
    value=value+value2;

    }

    Console.WriteLine(value);

string name = "steve";
if (name == "bob") 
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else 
    Console.WriteLine("Found Chuck");

int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");


// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
} else if (product[0] == "02")
{
    type = "T-Shirt";
} else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
} else if (product[1] == "MN")
{
    color = "Maroon";
} else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
} else if (product[2] == "M")
{
    size = "Medium";
} else if (product[2] == "L")
{
    size = "Large";
} else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");



//----------------------------------New Code Starts here ------------------------------

*/
/*

string sku = "01-MN-L";
string[] product = sku.Split('-');
string type = "";
string color = "";
string size = "";

switch(product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type= "Sweat pants";
        break;
    default:
        type="other";
        break;
}
switch(product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}
switch(product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}
Console.WriteLine($"Product: {size} {color} {type}");
*/


/*
string sku = "01-MN-L";
string[] product = sku.Split('-');
string type = "";
string color = "";
string size = "";

foreach (string item in product)
    {
    switch(item)
        {
        case "01":
            type = "Sweat shirt";
            break;
        case "02":
            type = "T-Shirt";
            break;
        case "03":
            type= "Sweat pants";
            break;
        default:
            type="other";
            break;
        }
    switch(item)
        {
        case "BL":
            color = "Black";
            break;
        case "MN":
            color = "Maroon";
            break;
        default:
            color = "White";
            break;
        }
    switch(item)
        {
        case "S":
            size = "Small";
            break;
        case "M":
            size = "Medium";
            break;
        case "L":
            size = "Large";
            break;
        default:
            size = "One Size Fits All";
            break;
        }

    }

Console.WriteLine($"Product: {size} {color} {type}");
*/

/*
string sku = "01-MN-L";
string type = "";
string color = "";
string size = "";
string[] product = sku.Split('-');
for (int i = 0; i < product.Length; i++)
    {
    Console.WriteLine(product[i]);
    switch(i)
        {
        case(0):
            switch(product[i])
            {
            case "01":
                type = "Sweat shirt";
                break;
            case "02":
                type = "T-Shirt";
                break;
            case "03":
                type= "Sweat pants";
                break;
            default:
                type="other";
                break;
            }
            break;
        case(1):
            switch(product[i])
            {
            case "BL":
                color = "Black";
                break;
            case "MN":
                color = "Maroon";
                break;
            default:
                color = "White";
                break;
            }
            break;
        case(2):
            switch(product[i])
            {
            case "S":
                size = "Small";
                break;
            case "M":
                size = "Medium";
                break;
            case "L":
                size = "Large";
                break;
            default:
                size = "One Size Fits All";
                break;
            }
            break;
        }
    }
Console.WriteLine($"Product: {size} {color} {type}");




for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}



for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}



string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}
*/
/*
string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i=0; i< names.Length; i++) // ise <= tp emsire mp logic error.
{
    Console.WriteLine(names[i]);

}



for (int i=1;i<=100;i++)
    {
    if (i%3==0 && i%5==0)
        {
        Console.WriteLine("FizzBuzz");
        }
    else if (i%3==0)
        {
        Console.WriteLine("Fizz");
        }
    else if (i%5==0)
        {
        Console.WriteLine("Buzz");
        }
    else
        {
        Console.WriteLine(i);
        }
    }
    */

/*

Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);


Random random = new Random();
int current = random.Next(1, 11);
*/

/*
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/
/*
Random random=new Random();
int hero=10;
int monster=10;
bool heroturn=true;
while ((hero>0)&&(monster>0))
{
    int attackpoints = random.Next(1, 10);
    if (heroturn==true)
        {
        monster=monster-attackpoints;
        Console.WriteLine($"Monster was damaged and lost {attackpoints} health and now has {monster}health");
        heroturn=false;
        }
    else
        {
        hero=hero-attackpoints;
        Console.WriteLine($"Hero was damaged and lost {attackpoints} health and now has {hero}health");
        heroturn=true;
        }
}
if (hero>monster)
{
    Console.WriteLine("Hero Wins");
}
else
{
    Console.WriteLine("Monster wins");
}

*/
/*
string? readResult;
Console.WriteLine("Enter a string:");
do
{
    readResult = Console.ReadLine();
} while (readResult == null);


*/
/*
string word="";
bool validcheck=false;
Console.WriteLine("Enter a string containing min of 3 letters");

do
{
    word=Console.ReadLine();
    if (word != null)
        {
        if (word.Length>=3)
            {
            validcheck=true;
            }
        
        else
            {
            Console.WriteLine("invalid entry, try again:");
            validcheck=false;
            }
        }
}while (validcheck==false);

Console.WriteLine("Well done you have entered the 3 or more ");





string? word;
bool validcheck=false;
Console.WriteLine("enter a string that is more then 3 letters :");
while (validcheck==false)
{
    word=Console.ReadLine();
    if (word !=null)
        {
        if (word.Length >= 3)
            {
            validcheck=true;
            }
        
        else Console.WriteLine("Invalid entry, please try again :");
        }
    else
        {
        Console.WriteLine("Invalid entry, please try again :");
        validcheck=false;
        
        }
}

Console.WriteLine("You have entered a valid word");

*/

/*
string? readResult;
Console.WriteLine("Enter a string:");
do
{
    readResult = Console.ReadLine();
} while (readResult == null);

*/
/*
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            continue;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);

*/
/*
string? readResult;
int numericValue=0;
//bool validNumber = false;
Console.WriteLine("Enter a valid integer between 5 and 10");
readResult=Console.ReadLine();
//validNumber = int.TryParse(readResult, out numericValue);
int.TryParse(readResult, out numericValue);
Console.WriteLine(readResult);
//Console.WriteLine($"the data being integer is {validNumber}");
Console.WriteLine($"The integer you typed in is {numericValue}");

*/

/*
string? readResult;
int numericValue=0;
bool validNumber = false;
bool fullvalidity=false;
Console.WriteLine("Enter a valid integer between 5 and 10");
do
{
    readResult=Console.ReadLine();
    validNumber = int.TryParse(readResult, out numericValue);
    if (validNumber)
        {
            if (numericValue>5 && numericValue<10)
            {
                fullvalidity=true;
            }
            else
            {
                Console.WriteLine($"You entered {numericValue}, please try between 5 and 10!");
            }
        }
    else
        {
            Console.WriteLine("Sorry, you entered an invalid number, please try again!");
        }


} while (fullvalidity==false);

Console.WriteLine($"Your input of  {numericValue} has been accepted !");

*/


/*

string? readResult;
int numericValue=0;
bool validNumber = false;
bool fullvalidity=false;

while (fullvalidity ==false)
{
    Console.WriteLine("Enter a valid integer between 5 and 10");
    readResult=Console.ReadLine();
    validNumber = int.TryParse(readResult, out numericValue);
    if (validNumber)
        {
            if (numericValue>5 && numericValue<10)
            {
                fullvalidity=true;
            }
                
            else
            {
                Console.WriteLine("Enter a number in the correct range please 5-10!");
            }
        }
    else
        {
            Console.WriteLine("enter a valid number cheers.");
        }


}

Console.WriteLine($"You have entered a valid integer i.e {numericValue}");
*/

/*
string response="";
bool validity=false;
while (validity==false)
{
    Console.WriteLine("Enter your role name (Administrator, Manager or User)");
    response=Console.ReadLine();
    response=response.ToLower().Trim();
    if (response=="administrator")
        {
            validity=true;
        }
    else if(response=="manager")
        {
            validity=true;
        }
    else if(response=="user")
        {
            validity=true;
        }
    else
        {
            Console.WriteLine($"The role name that you entered\"{response}\"is not valid.Enter correct role");
        }


}
Console.WriteLine($"Your input value ({response}) has been accepted. ");

*/



//IndexOf()

/*
string[] myStrings = {"I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"};

string[] myStringsTwo={};
int periodLocation=1;
string myString="";

for (int i=0;i<myStrings.Length;i++)
    {
    
        myString=myStrings[i];
        periodLocation=myString.IndexOf(".");
        if(periodLocation != -1)
            myString.Remove(periodLocation,1);
            Console.WriteLine(myString);


    }   


*/


// Using Remove() method to remove a specific character from each string


/////////////////////////////////////////////////////////////
///
/*
string[] myStrings = {"I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"};
for (int i = 0; i < myStrings.Length; i++)
{
    string myString=myStrings[i];

    int position = 0;

    while (true)
    {
        position = myString.IndexOf(".");
        
        if (position != -1)
        {
            string substring = myString.Substring(0, position); // Extract substring and remove leading/trailing spaces
            Console.WriteLine(substring.TrimStart());
            myString = myString.Substring(position + 1).TrimStart(); // Update myString to start after the period
        }
        else
        {
            Console.WriteLine(myString.TrimStart()); // Print the remaining part of myString (after the last period)
            break;
        }
    }
}

*/
/*
string myString = "I like pizza. I like roast chicken. I like salad";
int position=0;
do{

    Console.WriteLine(myString.IndexOf("."));
    position= myString.IndexOf(".");
    myString=myString.Substring(0,position);
    Console.WriteLine(myString);
    myString=myString.Remove(position);
    
} while (position !=-1);

*/

/*
string myString = "I like pizza. I like roast chicken. I like salad";
int position=0;

while (true)
    {
    
    position= myString.IndexOf(".");
    if (position !=-1)
        {
        myString=myString.Substring(0,position);
        Console.WriteLine(myString);
        myString=myString.Remove(0,position);

        }

    else
    {
        break;
    }
    }

    */
/*
position= myString.IndexOf(".");
myString=myString.Substring(0,position);
Console.WriteLine(myString);


myString=myString.Remove(position,myString.Length-1);
Console.WriteLine(myString);

*/
/*
string myString = "I like pizza. I like roast chicken. I like salad";
int position = 0;

while (true)
{
    position = myString.IndexOf(".");
    
    if (position != -1)
    {
        string substring = myString.Substring(0, position); // Extract substring and remove leading/trailing spaces
        Console.WriteLine(substring);
        myString = myString.Substring(position + 1); // Update myString to start after the period
    }
    else
    {
        Console.WriteLine(myString); // Print the remaining part of myString (after the last period)
        break;
    }
}

*/