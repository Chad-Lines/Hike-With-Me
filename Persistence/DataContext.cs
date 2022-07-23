using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        
        }

        public DbSet<Hike> Hikes { get; set; }

        /* To Create a Migration:
         * 1. Launch CMD
         * 2. Navigate to the ...\repos\Hike With Me directory
         * 3. Run dotnet tool install --global dotnet-ef --version 6.0.7 (if it's not installed already)
         * 4. dotnet tool update --global dotnet-ef --version 6.0.7 (if it is installed)
         * 5. Run dotnet ef migrations add InitialCreate -p Persistence -s API
         * 5.A - If it doesn't work, edit the API.csproj file and add 
         *      "<GenerateRuntimeConfigurationFiles>True</GenerateRuntimeConfigurationFiles>" (without quotes)
         *      to the <PropertyGroup> section and try again
         */
    }
}
