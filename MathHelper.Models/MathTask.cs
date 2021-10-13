using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper.Models
{
    public class MathTask
    {
        public int Id { get; set; }

        public ApplicationUser Author { get; set; }

        public TaskType Type {get; set;}

        public String PhotoPath1 { get; set; }

        public String PhotoPath2 { get; set; }

        public String PhotoPath3 { get; set; }
    }
}
