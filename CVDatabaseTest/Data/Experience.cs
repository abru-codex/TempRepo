namespace CVDatabaseTest.Data
{
    public class Experience
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public string Companay { get; set; }
        public DateTime JoiningDate { get; set; }
        public DateTime ResignationDate { get; set; }
        public ICollection<string>? Responsibilities { get; set; }
        public int CvId { get; set; }
        public Cv? Cv { get; set; }
    }
}
