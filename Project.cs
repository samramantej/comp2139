﻿namespace week2_1.Models
{
    public class Project
    {
        public int ProjectId {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }

    }
}
