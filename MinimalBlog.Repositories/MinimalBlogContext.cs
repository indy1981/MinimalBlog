using Microsoft.EntityFrameworkCore;
using MinimalBlog.Models;
using MinimalBlog.Models.Enums;
using System;
using System.Linq;

namespace MinimalBlog.Repositories
{
    public class MinimalBlogContext : DbContext
    {
        public MinimalBlogContext()
        {
        }

        public MinimalBlogContext(DbContextOptions<MinimalBlogContext> options) : base(options)
        { }

        public DbSet<Entry> Entrys { get; set;}

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new { 
                Id = 1,
                Username = "adrian", //Password: makingsense@99
                PasswordHash = StringToByteArray("7A01B7AC6140EAE80428A202F717EE960190B3C437B6BF9B6100F8B9163D4291CBE7AC4DEF96B8FE42564805E0B6213B5FBA39D7E843FBCA47F8FC59F7C97958"),
                PasswordSalt = StringToByteArray("D0073963B25058CC7F6F1EE5309BCA7544D3148C868A473D11415CAA034464C873E8CA1682C420C91F32A1E16CC6191AB125E0EBBDEED05EA1133D0B5D246B48F69C66A8CA21866C7DF1290EF63080A5C99D519AD7052FBE6393BBD390E2C1C904DB37DB6CB8BF92F424C71B6DBB008DDD1D65F61A4735C6C1D289369A8A9751"),
            },
            new
            {
                Id = 2,
                Username = "juan", //Password: minimal@123
                PasswordHash = StringToByteArray("24426244F42560C76E8DBD57D7ED5A93A7E60D2E94353290C0500E4ECF17805F154F7B148F8B83984567ECBF5B62D6FAB5DC0C6C9BA8A9EEC9E3E167B4006CB6"),
                PasswordSalt = StringToByteArray("11F4C15DFD300BA6D69B4AE3FF4F2C3E3B52BBBCC52968CF4AE1F7862A9A02974A65F55EE56A688666E460B739E6164849266CD856304A9FD7ACE7996E0A3A8D27EF9B653A5CA28E1B25256ECDEB36C866417DB1FAA3E3297121022D5FEACA17A23496B48AB24FA833C104C312A2F693AB6BC94FE1C06AAC3E850FA37F3266B1"),
            });

            modelBuilder.Entity<Entry>().HasData(new
            {
                Id = 1,
                UserId = 1,
                Title = "Brienne’s Rescue Of Sansa & Being Knighted",
                Created = DateTime.UtcNow,
                State = EntryStateEnum.Public,
                Image = "https://www.ablogofthrones.com/wp-content/uploads/2018/01/Sansa-Knights-Brienne-1920x1079.jpg",
                Summary = "Having just missed Sansa Stark’s signal, Brienne of the Tarth and her squire – Podrick Payne – went in search of her after she escaped her abusive husband, Ramsay Bolton.",
                Content = $"Just as the Bolton men found Sansa and Theon Greyjoy – whom helped her escape from Winterfell in the last episode of season 5 of HBO’s Game of Thrones – and were about to take them back to Ramsay – who would surely punish them severally – Brienne charged in on horseback and took them out with Oathkeeper – the Valyrian steel sword that Jaime Lannister gave her to rescue the Stark girls with.Sansa knighted Brienne, with the help of Theon Greyjoy, like her mother did before her and took her into her service as her sworn sword and shield."
            });

            modelBuilder.Entity<Entry>().HasData(new
            {
                Id = 2,
                UserId = 1,
                Title = "Jeor Mormont Offers Longclaw To Jon Snow",
                Created = DateTime.UtcNow.AddDays(-1),
                State = EntryStateEnum.Private,
                Image = "https://www.ablogofthrones.com/wp-content/uploads/2018/01/Jeor-Mormont-Offers-Longclaw-To-Jon-Snow-1920x1080.jpg",
                Summary = "Having saved Jeor Mormont from one of the undead, Jon Snow was gifted with Longclaw – the ancestral Valyrian steel sword of House Mormont. He reveals that he had a new pommel made in the form of a wolf rather than a bear, to honour House Stark – the House of Jon’s believed to be father, Ned Stark.",
                Content = $"Jeor explained the history behind the sword and who it belonged to, and who is was meant for, before offering it to Jon. He tries to refuse, but Jeor tells him that he has earnt it by saving his life.It emphasises the respect and gratitude that Jon earnt for his heroic act, and emphasises that he is a hero – possibly the overall hero of the entire series."
            });

            modelBuilder.Entity<Entry>().HasData(new
            {
                Id = 3,
                UserId = 1,
                Title = "The Nights Watch Drops The Scythe",
                Created = DateTime.UtcNow.AddDays(-2),
                State = EntryStateEnum.Public,
                Image = "https://www.ablogofthrones.com/wp-content/uploads/2018/01/Nights-Watch-Drops-The-Sycthe-1920x1079.jpg",
                Summary = "As the Wildlings were climbing the Wall, Ed gave the order for the Scythe to be dropped in order to prevent them from crossing the Wall and venturing south to raid and kill people.",
                Content = $"The Nights Watch Brother followed his command and dropped it. The large, anchor looking metal weapon was dropped from the top of the Wall and left to swing across the side. The large, metal weapon scraped into the Wall as it did so and took out all of the Wildlings.They screamed and cried out as it crushed them and knocked them from the Wall."
            });

            modelBuilder.Entity<Entry>().HasData(new
            {
                Id = 4,
                UserId = 1,
                Title = "Title here",
                Created = DateTime.UtcNow.AddDays(-2),
                State = EntryStateEnum.Draft                
            });

            modelBuilder.Entity<Entry>().HasData(new
            {
                Id = 5,
                UserId = 2,
                Title = "Daenerys Getting Laid On Her Own Terms",
                Created = DateTime.UtcNow,
                State = EntryStateEnum.Public,
                Image = "https://www.ablogofthrones.com/wp-content/uploads/2018/01/Daenerys-Daario-Bedroom-1920x1079.jpg",
                Summary = "Having not had a romantic or sexual partner since season 1 of HBO’s Game of Thrones, Daenerys Targaryen gave into her desires in season 4 when Daario Naharis – whom she had chemistry and tension with since meeting – came to her chambers.",
                Content = $"After pouring herself a glass of red wine and sitting in her chair in a seductive manner, she told Daario to take off his clothes since that was what he did best."
            });

            modelBuilder.Entity<Entry>().HasData(new
            {
                Id = 6,
                UserId = 2,
                Title = "Jorah Is Greeted Back By Daenerys",
                Created = DateTime.UtcNow.AddDays(-1),
                State = EntryStateEnum.Private,
                Image = "https://www.ablogofthrones.com/wp-content/uploads/2018/01/Daenerys-Takes-Jorah-Back-1920x1080.jpg",
                Summary = "After having had an emotional goodbye with Jorah in which he confesses his love for her, Jorah returned to Daenerys after getting rid of the Greyscale that he contracted while sailing through old Valyria.",
                Content = $"She and Jon Snow were standing atop the cliffs of Dragonstone when the Dothraki told her that a man claiming to be her friend was there. She turned to see Jorah behind them. Daenerys looks ready to cry at the sight of her longest and most trusted friend.She informs Jon Snow of who he is and he tells Jorah that his father was a great man.Jorah offers Daenerys his service, if she will have him.She then tells him it will be her honour and then embraces him warmly and affectionately."
            });

            modelBuilder.Entity<Entry>().HasData(new
            {
                Id = 7,
                UserId = 2,
                Title = "Very good draft",
                Created = DateTime.UtcNow.AddDays(-2),
                State = EntryStateEnum.Draft                
            });

        }

        public byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }


    }
}
