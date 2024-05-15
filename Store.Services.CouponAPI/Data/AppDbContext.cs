﻿using Microsoft.EntityFrameworkCore;
using Store.Services.CouponAPI.Models;

namespace Store.Services.CouponAPI.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        
        }
        public DbSet<Coupon> Coupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Coupon>().HasData(new Coupon
            {
                CouponId = 5,
                CouponCode = "mcn20",
                DiscountAmount = 20,
                MinAmount = 100
            });
        }
    }
}
