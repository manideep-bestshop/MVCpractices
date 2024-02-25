namespace Library
{
    public class Class1
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public AnimalType AnimalType { get; set; }
    }
    public enum AnimalType
    {
        Domestic,
        Wild,
        Both
    }
}
