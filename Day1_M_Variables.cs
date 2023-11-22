- review1

public bool IsShopOpen(string day)
{
    if (!string.IsNullOrEmpty(day))
    {
        day = day.ToLower();
        if (day == "friday")
        {
            return true;
        }
        else if (day == "saturday")
        {
            return true;
        }
        else if (day == "sunday")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    {
        return false;
    }

}

public bool IsShopOpen(string day)
{
    if (!string.IsNullOrEmpty(day))
    {
        return false;
    }

    var openingDays = new[] {"friday", "saturday", "sunday"};
    return openingDays.Any(d => d == day.ToLower())
}

- review3

public long Fibonacci(int n)
{
    if (n < 50)
    {
        if (n != 0)
        {
            if (n != 1)
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
            else
            {
                return 1;
            }
        }
        else
        {
            return 0;
        }
    }
    else
    {
        throw new System.Exception("Not supported");
    }
}

public long Fibonacci(int n)
{
    if (n >= 50)
    {
        throw new System.Exception("Not supported");
    }

    if (n == 0 || n==1)
    {
        return n;
    }
            
    return Fibonacci(n - 1) + Fibonacci(n - 2);
}

- review4

var l = new[] { "Austin", "New York", "San Francisco" };

for (var i = 0; i < l.Count(); i++)
{
    var li = l[i];
    DoStuff();
    DoSomeOtherStuff();

    // ...
    // ...
    // ...
    // Wait, what is `li` for again?
    Dispatch(li);
}

var listOfCity = new[] { "Austin", "New York", "San Francisco" };

for (var i = 0; i < listOfCity.Count(); i++)
{
    var city = listOfCity[i];
    DoStuff();
    DoSomeOtherStuff();

    // ...
    // ...
    // ...
    // Wait, what is `li` for again?
    Dispatch(city);
}

- review5

if (userRole == 8) // Check if Admin
{
    
}

string USER_ADMIN_ROLE = Console.ReadLine()
if (USER_ADMIN_ROLE == "admin") // Check if Admin 
{
    
}

- review6

public class Car
{
    public string CarMake { get; set; }
    public string CarModel { get; set; }
    public string CarColor { get; set; }

    //...
}

public class Car
{
    public string make { get; set; }
    public string model { get; set; }
    public string color { get; set; }

    //...
}

- review7

var ymdstr = DateTime.UtcNow.ToString("MMMM dd, yyyy");

var YEAR_MONTH_DATE = DateTime.UtcNow.ToString("MMMM dd, yyyy");

- review9

public void CreateMicrobrewery(string name = null)
{
    var breweryName = !string.IsNullOrEmpty(name) ? name : "Hipster Brew Co.";
    // ...
}

public void CreateMicrobrewery(string name = "Hipster Brew Co.")
{
    // ...
}



