Console.WriteLine("Random instult generator, press a key");
string[] insults = { "You suck", "You smell", "Your mom can't fit inside an elevator","You're so skinny you look like Titus (insult from Titus)" };
Random rand = new Random();
int num = 0;
while (1 < 2)
{
    Console.ReadKey();
    Console.Clear();
    num = rand.Next(0,4);
    Console.WriteLine(insults[num]);
}