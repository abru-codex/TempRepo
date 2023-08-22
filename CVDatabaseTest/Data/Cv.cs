namespace CVDatabaseTest.Data
{
    public class Cv
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Number { get; set; }
        public string Skype { get; set; }
        public string Linkdin { get; set; }
        public string Address { get; set; }
        public string Summary { get; set; }
        public ICollection<string>? Trainings { get; set; }
        public ICollection<SkillCv>? Skills { get; set; }
        public ICollection<Experience>? Experiences { get; set; }
        public ICollection<Project>? Projects { get; set; }
        public ICollection<Education>? Educations { get; set; }
        public ICollection<Reference>? References { get; set; }
        public int DemoUserId { get; set; }
        public DemoUser? DemoUser { get; set; }
    }
}
