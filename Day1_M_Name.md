- review1

//Avoid using bad names
int d; // elapsed time in days

int elapsedTimeInDays;

- review2

var dataFromDb = db.GetFromService().ToList(); // Get List of employees 

var employeeListFromDb = employeeDb.GetEmployessFromDB.ToList();

- review3

int iCounter;
string strFullName;
DateTime dModifiedDate;

int counter;
string fullName;
DateTime modifiedDate;

- review4

public bool IsShopOpen(string pDay, int pAmount)
{
    // some logic
}

public bool IsShopOpen(string day, int amount)
{
    // some logic
}

- review5

const int DAYS_IN_WEEK = 7;
const int daysInMonth = 30;

var songs = new List<string> { 'Back In Black', 'Stairway to Heaven', 'Hey Jude' };
var Artists = new List<string> { 'ACDC', 'Led Zeppelin', 'The Beatles' };

bool EraseDatabase() {}
bool Restore_database() {}

class animal {}
class Alpaca {}

const int DAYS_IN_WEEK = 7;
const int DAYS_IN_MONTH = 30;

var songs = new List<string> { 'Back In Black', 'Stairway to Heaven', 'Hey Jude' };
var Artists = new List<string> { 'ACDC', 'Led Zeppelin', 'The Beatles' };

bool EraseDatabase() {}
bool Restore_database() {}

class Animal {}
class Alpaca {}

- review6

public class Employee
{
    public Datetime sWorkDate { get; set; } // get set Start Working Date
    public Datetime modTime { get; set; } // get set Modification Time
}

public class Employee
{
    public Datetime startingWorkDate { get; set; } // get set Start Working Date
    public Datetime modificationTime { get; set; } // get set Modification Time
}

- review7

var employeephone;

public double CalculateSalary(int workingdays, int workinghours)
{
    // some logic
}

var employeePhone;

public double CalculateSalary(int workingDays, int workingHours)
{
    // some logic
}
