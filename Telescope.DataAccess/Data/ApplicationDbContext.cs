using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Telescope.Models;

namespace Telescope.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Bút viết", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Tập vở", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Thước kẻ", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Name = "NGUYEN MINH HOANG",
                    StreetAddress="351A Lạc Long Quân",
                    Ward="Phường 5",
                    District ="Quận 11",
                    Province ="Tp. Hồ Chí Minh",
                    PostalCode="12121",
                    PhoneNumber="6669990000"
                },
                new Company
                {
                    Id = 2,
                    Name = "TRAN MINH KHOI",
                    StreetAddress="351A Lạc Long Quân",
                    Ward="Phường 5",
                    District ="Quận 11",
                    Province ="Tp. Hồ Chí Minh",
                    PostalCode="12121",
                    PhoneNumber = "1113335555"
                },
                new Company
                {
                    Id = 3,
                    Name = "LE VAN QUY",
                    StreetAddress="280 An Dương Vương",
                    Ward="Phường 4",
                    District ="Quận 5",
                    Province ="Tp. Hồ Chí Minh",
                    PostalCode="12121",
                    PhoneNumber = "7779990000"
                }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Bút Bi Thiên Long",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 2,
                    Title = "Bút lông dầu Thiên Long",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ListPrice = 40,
                    Price = 30,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 1,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 3,
                    Title = "TẬP HỌC SINH 96 TRANG 4 Ô LY VUÔNG 70 GSM ĐIỂM 10",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ListPrice = 55,
                    Price = 50,
                    Price50 = 40,
                    Price100 = 35,
                    CategoryId = 2,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 4,
                    Title = "TẬP HỌC SINH 96 TRANG 5 Ô LY VUÔNG 80 GSM ĐIỂM 10",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ListPrice = 70,
                    Price = 65,
                    Price50 = 60,
                    Price100 = 55,
                    CategoryId = 2,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 5,
                    Title = "Thước dẻo PVC 20cm Điểm 10",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ListPrice = 30,
                    Price = 27,
                    Price50 = 25,
                    Price100 = 20,
                    CategoryId = 3,
                    ImageUrl=""
                },
                new Product
                {
                    Id = 6,
                    Title = "Thước dẻo PVC 30cm Điểm 10",
                    Description = "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ",
                    ListPrice = 25,
                    Price = 23,
                    Price50 = 22,
                    Price100 = 20,
                    CategoryId = 3,
                    ImageUrl=""
                }
                );
        }
    }
}
