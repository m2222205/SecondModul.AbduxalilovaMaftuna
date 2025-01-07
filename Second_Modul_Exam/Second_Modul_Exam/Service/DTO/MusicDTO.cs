using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Modul_Exam.Service.DTO
{
    public class MusicDTO
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public double MB { get; set; }
        public string AuthorName { get; set; }
        public string Description { get; set; }
        public int QuentityLikes { get; set; }

    }
}
