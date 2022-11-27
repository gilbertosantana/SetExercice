namespace SetExercice.Entities
{
    internal class LogRecord
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public LogRecord(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is LogRecord))
            {
                return false;
            }
            LogRecord? other = obj as LogRecord;
            return Name.Equals(other!.Name);
        }
    }
}
