using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SAMMI.Server.Data.SammiContext
{
	internal class SammiContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// TODO: Set up a database for SAMMI, store connection string in seperate file that is *not* to be included on GitHub
			optionsBuilder.UseSqlServer("");
		}
	}
}
