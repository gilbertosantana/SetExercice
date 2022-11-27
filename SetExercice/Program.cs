using SetExercice.Entities;

HashSet<LogRecord> set = new HashSet<LogRecord>(); ;

Console.Write("Enter file full path: ");

string path = @Console.ReadLine()!;
#if !DEFAULT
try
{
    using(StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine()!.Split(' ');
            string name = line[0];
            DateTime instant = DateTime.Parse(line[1]);
            set.Add(new LogRecord(name, instant));
        }
        Console.WriteLine("Total users: " + set.Count);
    }
}
catch(IOException e)
{
    Console.WriteLine("An error ocurred");
	Console.WriteLine(e.Message);
}