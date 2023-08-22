using System.Security.Principal;

namespace CVDatabaseTest.Data
{
    public class SkillCv
    {
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
        public int CvId { get; set; }
        public Cv Cv { get; set; }
    }
}
