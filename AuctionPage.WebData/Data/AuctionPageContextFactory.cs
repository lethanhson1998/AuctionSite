using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace AuctionPage.WebData.Data
{
    public class AuctionPageContextFactory : IDesignTimeDbContextFactory<AuctionPageDbContext>
    {
        public AuctionPageDbContext CreateDbContext(string[] args)
        {
            //throw new NotImplementedException();
            var OptionBuilder = new DbContextOptionsBuilder<AuctionPageDbContext>();
            OptionBuilder.UseSqlServer("Server=DESKTOP-VPCKNOJ\\SQLEXPRESS;Database=AuctionPageDB;Trusted_Connection=True;", b=>b.MigrationsAssembly("AuctionPage.WebData"));
            return new AuctionPageDbContext(OptionBuilder.Options);
        }
    }
}
