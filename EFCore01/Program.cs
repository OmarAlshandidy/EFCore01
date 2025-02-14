using EFCore01.Context;
using Microsoft.EntityFrameworkCore;

namespace EFCore01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppDbContext db = new AppDbContext();
                //db.Database.Migrate();
        }
    }
}
