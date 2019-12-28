using System;
using System.ComponentModel.DataAnnotations;
    public class User
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string family { get; set; }

        public DateTime registration { get; set; }
    }

