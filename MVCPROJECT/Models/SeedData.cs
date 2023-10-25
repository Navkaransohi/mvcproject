using MVCPROJECT.Data;

namespace MVCPROJECT.Models
{
    public class SeedData
    {
        public static void Initialize(AppDbcontext context)
        {
            // Look for any existing records
            if (context.Artist.Any())
            {
                return;   // Database has been seeded
            }

            context.Artist.AddRange(
                new Artist
                {
                    Name = "Satinder Sartaaj",
                    AlbumName = "Cheerey Wala Sartaaj",
                    Shows = "Sartaaj Live Concert 2023",
                    Places = "Various Cities",
                    Songs = "Sufi and Punjabi Hits",
                    Music = "Sufi, Punjabi, and Folk"
                },
                new Artist
                {
                    Name = "Sidhu Moose Wala",
                    AlbumName = "Moosetape",
                    Shows = "Live Concert 2023",
                    Places = "Los Angeles",
                    Songs = "Punjabi",
                    Music = "Punjabi"
                },
                new Artist
                {
                  Name = "Karan Aujla",
                    AlbumName = "Latest Hits",
                    Shows = "World Tour 2023",
                    Places = "Various Cities",
                    Songs = "Top Punjabi Hits",
                    Music = "Punjabi"
                },
                new Artist
                {
                   Name = "Diljit Dosanjh",
                    AlbumName = "G.O.A.T.",
                    Shows = "International Tour 2023",
                    Places = "Various Countries",
                    Songs = "Punjabi and Hindi Hits",
                    Music = "Punjabi and Bollywood"
                }
            );
            context.SaveChanges();
        }
    }
}