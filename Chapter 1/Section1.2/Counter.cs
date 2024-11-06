namespace Section1._2
{
    internal class Counter
    {
        public int Total { get; set; }
        public string Name { get; }

        public void increment() { Total++; }

        public override string ToString()
        {
            return "Counter name:" + Name;
        }

        public Counter()
        { }
        public Counter(string name) { Name = name; }
    }
}
