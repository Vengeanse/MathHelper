using MathHelper.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper.Services
{
    public class SQLRepository : IDBRepository
    {
        private readonly ApplicationDbContext _context;

        public SQLRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
