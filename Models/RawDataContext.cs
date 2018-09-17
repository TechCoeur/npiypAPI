using System;
using Microsoft.EntityFrameworkCore;

namespace npiypAPI.Models
{
    public class RawDataContext : DbContext
    {
        public RawDataContext(DbContextOptions<RawDataContext> options)
            : base(options)
        {

        }

        public DbSet<RawData> RawDataItems { get; set; }

        internal int Count()
        {
            throw new NotImplementedException();
        }
    }
}