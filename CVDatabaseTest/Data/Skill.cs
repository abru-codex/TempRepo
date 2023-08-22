namespace CVDatabaseTest.Data
{
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<SkillCv>? Cvs { get; set; }
    }
}
