// Three Basic Arrays
int[] arr = {0,1,2,3,4,5,6,7,8,9};
string[] names = {"Tim", "Martin", "Nikki", "Sara"};
Boolean[] arr2 = new Boolean[10];

for (int i = 0; i < arr2.Length; i += 2){
    arr2[i] = true;
}

foreach(Boolean idx in arr2){
    Console.WriteLine(idx);
}

// List of Flavors
List<string> iceCreams = new();
iceCreams.Add("Vanilla");
iceCreams.Add("Strawberry");
iceCreams.Add("Chocolate");
iceCreams.Add("Peanut Butter");
iceCreams.Add("Salted Caramel");
Console.WriteLine(iceCreams.Count);
Console.WriteLine(iceCreams[2]);
iceCreams.RemoveAt(2);
Console.WriteLine(iceCreams.Count);

// User Dictionary
Dictionary<string, string> User = new();
User.Add(names[0], iceCreams[0]);
User.Add(names[1], iceCreams[1]);
User.Add(names[2], iceCreams[2]);
User.Add(names[3], iceCreams[3]);


foreach(KeyValuePair<string,string> item in User)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}



