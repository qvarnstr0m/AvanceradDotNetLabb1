// See https://aka.ms/new-console-template for more information

using AvanceradDotNetLabb1;

BoxCollection boxCollection = new BoxCollection();
Box box1 = new Box(1, 2, 3);
Box box2 = new Box(1, 2, 3);
Box box3 = new Box(2, 2, 3);
Box box4 = new Box(2, 3, 3);
Box box5 = new Box(3, 3, 3);


boxCollection.Add(box1);
boxCollection.Add(box2);
boxCollection.Add(box3);
boxCollection.Add(box4);
boxCollection.Add(box5);

foreach (var item in boxCollection)
{
    Console.WriteLine(item.Height + " " + item.Width + " " + item.Length);
}


Console.WriteLine(boxCollection.Remove(box1) ? "Box 1 Removed" : "Box 1 Not removed");
Console.WriteLine(boxCollection.Contains(box1));

foreach (var item in boxCollection)
{
    Console.WriteLine(item.Height + " " + item.Width + " " + item.Length);
}

