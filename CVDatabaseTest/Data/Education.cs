namespace CVDatabaseTest.Data
{
    public class Education
    {
        public int Id { get; set; }
        public string Level { get; set; }
        public string University { get; set; }
        public string Grade { get; set; }
        public DateTime PassingYear { get; set; }
        public int CvId { get; set; }
        public Cv? Cv { get; set; }
    }
}
