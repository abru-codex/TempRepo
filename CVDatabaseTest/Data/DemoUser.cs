namespace CVDatabaseTest.Data
{
    public class DemoUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Cv>? Cvs { get; set; } = new List<Cv>();
 }
}
