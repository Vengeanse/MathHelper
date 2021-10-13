using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper.Models
{
    [Keyless]
    public class SolvedTask
    {
        public MathTask Task { get; set; }

        public ApplicationUser User { get; set; }


    }
}
