using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC_EF_Template.Models
{
    public class Subject
    {
        public int SubjectID { get; set; }
        public string Name { get; set; }

        [DisplayFormat(NullDisplayText = "No Grade")]
        public Grade? Grade { get; set; }
    }

    public enum Grade
    {
        A, B, C, D, F
    }
}
