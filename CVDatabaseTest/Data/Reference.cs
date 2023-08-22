namespace CVDatabaseTest.Data
{
    public class Reference
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Compnay { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int Number { get; set; }
        public int CvId { get; set; }
        public Cv? Cv { get; set; }
    }
}
