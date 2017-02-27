using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CSharpCExam.Models.DB
{
    public class Entry
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(256)]
        public string Nickname { get; set; }
        [MaxLength(256)]
        public string Bio { get; set; }
        public int Answer1 { get; set; }
        public int Answer2 { get; set; }
        public int Answer3 { get; set; }
        public int Answer4 { get; set; }
    }
}