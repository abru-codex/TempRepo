﻿namespace CVDatabaseTest.Data
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int CvId { get; set; }
        public Cv? Cv { get; set; }

    }
}
