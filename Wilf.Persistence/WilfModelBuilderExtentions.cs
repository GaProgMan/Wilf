using Microsoft.EntityFrameworkCore;
using Wilf.Entities;

namespace Wilf.Persistence
{
    public static class WilfModelBuilderExtentions
    {
        /// <summary>
        /// Used to create the the primary keys for Wilf's database model
        /// </summary>
        /// <param name="builder">An instance of the <see cref="ModelBuilder"/> to act on</param>
        public static void AddPrimaryKeys(this ModelBuilder builder)
        {
            builder.Entity<Season>().ToTable("Seasons").HasKey(s => s.SeasonId);
            builder.Entity<Episode>().ToTable("Episodes").HasKey(e => e.EpisodeId);
        }

        /// <summary>
        /// Used to create the Foreign keys for Wilf's database model
        /// </summary>
        /// <param name="builder">An instance of the <see cref="ModelBuilder"/> to act on</param>
        public static void AddForeignKeys(this ModelBuilder builder)
        {
            builder.Entity<Season>().HasMany(s => s.Episodes).WithOne(e => e.Season);
        }
    }
}