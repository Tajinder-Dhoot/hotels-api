﻿using System;
using Microsoft.EntityFrameworkCore;

namespace HotelsAPIs.Data
{
	public class HotelListingDbContext: DbContext
	{
		public HotelListingDbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<Hotel> Hotels { get; set; }

		public DbSet<Country> Countries { get; set; }
	}
}

