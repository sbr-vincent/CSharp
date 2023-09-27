// 1. Iterate and print values
using System.Linq.Expressions;

static void PrintList(List<string> MyList)
{
    // Your code here
    foreach(string name in MyList){
        Console.WriteLine(name);
    }
}
List<string> TestStringList = new List<string>() {"Harry", "Steve", "Carla", "Jeanne"};
PrintList(TestStringList);

// 2. Print Sum
static void SumOfNumbers(List<int> IntList)
{
    // Your code here
    int sum = 0;
    foreach(int count in IntList){
        sum += count;
    }

    Console.WriteLine(sum);
}
List<int> TestIntList = new List<int>() {2,7,12,9,3};
// You should get back 33 in this example
SumOfNumbers(TestIntList);

// 3. Find Max
static int FindMax(List<int> IntList){
    int largest = IntList[0];

    for(int i = 1; i < IntList.Count; i++){
        if(largest < IntList[i]){
            largest = IntList[i];
        }
    }

    return largest;
}
List<int> TestIntList2 = new List<int>() {-9, 12, 10, 3, 17, 5};

Console.WriteLine(FindMax(TestIntList2));

// 4. Square values
static List<int> SquareValues(List<int> IntList)
{
    for(int i = 0; i < IntList.Count; i++){
        IntList[i] *= IntList[i];
    }

    foreach(int doubleVal in IntList){
        Console.WriteLine(doubleVal);
    }

    return IntList;
}
List<int> TestIntList3 = new List<int>() {1,2,3,4,5};
// You should get back [1,4,9,16,25], think about how you will show that this worked
SquareValues(TestIntList3);

// 5. Replace Negative Numbers with 0
static int[] NonNegatives(int[] IntArray)
{
    // Your code here
    for(int i = 0; i < IntArray.Length; i++){
        if(IntArray[i] < 0){
            IntArray[i] = 0;
        }
    }

    foreach(int doubleVal in IntArray){
        Console.WriteLine(doubleVal);
    }

    return IntArray;
}
int[] TestIntArray = new int[] {-1,2,3,-4,5};
// You should get back [0,2,3,0,5], think about how you will show that this worked
NonNegatives(TestIntArray);

// 6. Print Dictionary
static void PrintDictionary(Dictionary<string,string> MyDictionary)
{
    // Your code here
    foreach(KeyValuePair<string,string> entry in MyDictionary){
        Console.WriteLine($"{entry.Key} - {entry.Value}");
    }
}
Dictionary<string,string> TestDict = new Dictionary<string,string>();
TestDict.Add("HeroName", "Iron Man");
TestDict.Add("RealName", "Tony Stark");
TestDict.Add("Powers", "Money and intelligence");
PrintDictionary(TestDict);

// 7. Find Key
static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
{
    // Your code here
    if(MyDictionary.ContainsKey(SearchTerm)){
        return true;
    }else{
        return false;
    }
}
// Use the TestDict from the earlier example or make your own
// This should print true
Console.WriteLine(FindKey(TestDict, "RealName"));
// This should print false
Console.WriteLine(FindKey(TestDict, "Name"));

// 8. Generate a Dictionary
// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 

List<string> names2 = new() {"Julie", "Harold", "James", "Monica"};
List<int> nums = new() {6,12,7,10};
static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    // Your code here
    Dictionary<string, int> person = new();
    for(int i = 0; i < Names.Count; i++){
        person.Add(Names[i], Numbers[i]);
    }

    foreach(KeyValuePair<string, int> entry in person){
        Console.WriteLine($"{entry.Key} - {entry.Value}");
    }

    return person;
}
// We've shown several examples of how to set your tests up properly, it's your turn to set it up!
// Your test code here
GenerateDictionary(names2, nums);









