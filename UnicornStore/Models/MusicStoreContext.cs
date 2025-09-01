using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
// Using fully qualified class name instead of namespace import


namespace UnicornStore.Models
{
    public class ApplicationUser : IdentityUser { }

    public class UnicornStoreContext : Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext<ApplicationUser>
    {
        public UnicornStoreContext(DbContextOptions<UnicornStoreContext> options)
            : base(options)
        {
            // TODO: #639
            //ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public System.Collections.Generic.ICollection<Blessing> Blessings { get; set; }
        public System.Collections.Generic.ICollection<Unicorn> Unicorns { get; set; }
        public System.Collections.Generic.ICollection<Order> Orders { get; set; }
        public System.Collections.Generic.ICollection<Genre> Genres { get; set; }
        public System.Collections.Generic.ICollection<CartItem> CartItems { get; set; }
        public System.Collections.Generic.ICollection<OrderDetail> OrderDetails { get; set; }
    }
}