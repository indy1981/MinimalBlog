﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MinimalBlog.Repositories;

namespace MinimalBlog.Repositories.Migrations
{
    [DbContext(typeof(MinimalBlogContext))]
    [Migration("20190414222737_AddEntriesSeed")]
    partial class AddEntriesSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MinimalBlog.Models.Entry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Image");

                    b.Property<int>("State");

                    b.Property<string>("Summary");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Entrys");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Just as the Bolton men found Sansa and Theon Greyjoy – whom helped her escape from Winterfell in the last episode of season 5 of HBO’s Game of Thrones – and were about to take them back to Ramsay – who would surely punish them severally – Brienne charged in on horseback and took them out with Oathkeeper – the Valyrian steel sword that Jaime Lannister gave her to rescue the Stark girls with.Sansa knighted Brienne, with the help of Theon Greyjoy, like her mother did before her and took her into her service as her sworn sword and shield.",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://www.ablogofthrones.com/wp-content/uploads/2018/01/Sansa-Knights-Brienne-1920x1079.jpg",
                            State = 0,
                            Summary = "Having just missed Sansa Stark’s signal, Brienne of the Tarth and her squire – Podrick Payne – went in search of her after she escaped her abusive husband, Ramsay Bolton.",
                            Title = "Brienne’s Rescue Of Sansa & Being Knighted",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Content = "Jeor explained the history behind the sword and who it belonged to, and who is was meant for, before offering it to Jon. He tries to refuse, but Jeor tells him that he has earnt it by saving his life.It emphasises the respect and gratitude that Jon earnt for his heroic act, and emphasises that he is a hero – possibly the overall hero of the entire series.",
                            Created = new DateTime(2019, 4, 13, 22, 27, 36, 986, DateTimeKind.Utc).AddTicks(7538),
                            Image = "https://www.ablogofthrones.com/wp-content/uploads/2018/01/Jeor-Mormont-Offers-Longclaw-To-Jon-Snow-1920x1080.jpg",
                            State = 2,
                            Summary = "Having saved Jeor Mormont from one of the undead, Jon Snow was gifted with Longclaw – the ancestral Valyrian steel sword of House Mormont. He reveals that he had a new pommel made in the form of a wolf rather than a bear, to honour House Stark – the House of Jon’s believed to be father, Ned Stark.",
                            Title = "Jeor Mormont Offers Longclaw To Jon Snow",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Content = "The Nights Watch Brother followed his command and dropped it. The large, anchor looking metal weapon was dropped from the top of the Wall and left to swing across the side. The large, metal weapon scraped into the Wall as it did so and took out all of the Wildlings.They screamed and cried out as it crushed them and knocked them from the Wall.",
                            Created = new DateTime(2019, 4, 12, 22, 27, 36, 986, DateTimeKind.Utc).AddTicks(7575),
                            Image = "https://www.ablogofthrones.com/wp-content/uploads/2018/01/Nights-Watch-Drops-The-Sycthe-1920x1079.jpg",
                            State = 0,
                            Summary = "As the Wildlings were climbing the Wall, Ed gave the order for the Scythe to be dropped in order to prevent them from crossing the Wall and venturing south to raid and kill people.",
                            Title = "The Nights Watch Drops The Scythe",
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2019, 4, 12, 22, 27, 36, 986, DateTimeKind.Utc).AddTicks(7596),
                            State = 1,
                            Title = "Title here",
                            UserId = 1
                        },
                        new
                        {
                            Id = 5,
                            Content = "After pouring herself a glass of red wine and sitting in her chair in a seductive manner, she told Daario to take off his clothes since that was what he did best.",
                            Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://www.ablogofthrones.com/wp-content/uploads/2018/01/Daenerys-Daario-Bedroom-1920x1079.jpg",
                            State = 0,
                            Summary = "Having not had a romantic or sexual partner since season 1 of HBO’s Game of Thrones, Daenerys Targaryen gave into her desires in season 4 when Daario Naharis – whom she had chemistry and tension with since meeting – came to her chambers.",
                            Title = "Daenerys Getting Laid On Her Own Terms",
                            UserId = 2
                        },
                        new
                        {
                            Id = 6,
                            Content = "She and Jon Snow were standing atop the cliffs of Dragonstone when the Dothraki told her that a man claiming to be her friend was there. She turned to see Jorah behind them. Daenerys looks ready to cry at the sight of her longest and most trusted friend.She informs Jon Snow of who he is and he tells Jorah that his father was a great man.Jorah offers Daenerys his service, if she will have him.She then tells him it will be her honour and then embraces him warmly and affectionately.",
                            Created = new DateTime(2019, 4, 13, 22, 27, 36, 986, DateTimeKind.Utc).AddTicks(9081),
                            Image = "https://www.ablogofthrones.com/wp-content/uploads/2018/01/Daenerys-Takes-Jorah-Back-1920x1080.jpg",
                            State = 2,
                            Summary = "After having had an emotional goodbye with Jorah in which he confesses his love for her, Jorah returned to Daenerys after getting rid of the Greyscale that he contracted while sailing through old Valyria.",
                            Title = "Jorah Is Greeted Back By Daenerys",
                            UserId = 2
                        },
                        new
                        {
                            Id = 7,
                            Created = new DateTime(2019, 4, 12, 22, 27, 36, 986, DateTimeKind.Utc).AddTicks(9183),
                            State = 1,
                            Title = "Very good draft",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("MinimalBlog.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PasswordHash = new byte[] { 48, 120, 55, 65, 48, 49, 66, 55, 65, 67, 54, 49, 52, 48, 69, 65, 69, 56, 48, 52, 50, 56, 65, 50, 48, 50, 70, 55, 49, 55, 69, 69, 57, 54, 48, 49, 57, 48, 66, 51, 67, 52, 51, 55, 66, 54, 66, 70, 57, 66, 54, 49, 48, 48, 70, 56, 66, 57, 49, 54, 51, 68, 52, 50, 57, 49, 67, 66, 69, 55, 65, 67, 52, 68, 69, 70, 57, 54, 66, 56, 70, 69, 52, 50, 53, 54, 52, 56, 48, 53, 69, 48, 66, 54, 50, 49, 51, 66, 53, 70, 66, 65, 51, 57, 68, 55, 69, 56, 52, 51, 70, 66, 67, 65, 52, 55, 70, 56, 70, 67, 53, 57, 70, 55, 67, 57, 55, 57, 53, 56 },
                            PasswordSalt = new byte[] { 48, 120, 68, 48, 48, 55, 51, 57, 54, 51, 66, 50, 53, 48, 53, 56, 67, 67, 55, 70, 54, 70, 49, 69, 69, 53, 51, 48, 57, 66, 67, 65, 55, 53, 52, 52, 68, 51, 49, 52, 56, 67, 56, 54, 56, 65, 52, 55, 51, 68, 49, 49, 52, 49, 53, 67, 65, 65, 48, 51, 52, 52, 54, 52, 67, 56, 55, 51, 69, 56, 67, 65, 49, 54, 56, 50, 67, 52, 50, 48, 67, 57, 49, 70, 51, 50, 65, 49, 69, 49, 54, 67, 67, 54, 49, 57, 49, 65, 66, 49, 50, 53, 69, 48, 69, 66, 66, 68, 69, 69, 68, 48, 53, 69, 65, 49, 49, 51, 51, 68, 48, 66, 53, 68, 50, 52, 54, 66, 52, 56, 70, 54, 57, 67, 54, 54, 65, 56, 67, 65, 50, 49, 56, 54, 54, 67, 55, 68, 70, 49, 50, 57, 48, 69, 70, 54, 51, 48, 56, 48, 65, 53, 67, 57, 57, 68, 53, 49, 57, 65, 68, 55, 48, 53, 50, 70, 66, 69, 54, 51, 57, 51, 66, 66, 68, 51, 57, 48, 69, 50, 67, 49, 67, 57, 48, 52, 68, 66, 51, 55, 68, 66, 54, 67, 66, 56, 66, 70, 57, 50, 70, 52, 50, 52, 67, 55, 49, 66, 54, 68, 66, 66, 48, 48, 56, 68, 68, 68, 49, 68, 54, 53, 70, 54, 49, 65, 52, 55, 51, 53, 67, 54, 67, 49, 68, 50, 56, 57, 51, 54, 57, 65, 56, 65, 57, 55, 53, 49 },
                            Username = "adrian"
                        },
                        new
                        {
                            Id = 2,
                            PasswordHash = new byte[] { 48, 120, 50, 52, 52, 50, 54, 50, 52, 52, 70, 52, 50, 53, 54, 48, 67, 55, 54, 69, 56, 68, 66, 68, 53, 55, 68, 55, 69, 68, 53, 65, 57, 51, 65, 55, 69, 54, 48, 68, 50, 69, 57, 52, 51, 53, 51, 50, 57, 48, 67, 48, 53, 48, 48, 69, 52, 69, 67, 70, 49, 55, 56, 48, 53, 70, 49, 53, 52, 70, 55, 66, 49, 52, 56, 70, 56, 66, 56, 51, 57, 56, 52, 53, 54, 55, 69, 67, 66, 70, 53, 66, 54, 50, 68, 54, 70, 65, 66, 53, 68, 67, 48, 67, 54, 67, 57, 66, 65, 56, 65, 57, 69, 69, 67, 57, 69, 51, 69, 49, 54, 55, 66, 52, 48, 48, 54, 67, 66, 54 },
                            PasswordSalt = new byte[] { 48, 120, 49, 49, 70, 52, 67, 49, 53, 68, 70, 68, 51, 48, 48, 66, 65, 54, 68, 54, 57, 66, 52, 65, 69, 51, 70, 70, 52, 70, 50, 67, 51, 69, 51, 66, 53, 50, 66, 66, 66, 67, 67, 53, 50, 57, 54, 56, 67, 70, 52, 65, 69, 49, 70, 55, 56, 54, 50, 65, 57, 65, 48, 50, 57, 55, 52, 65, 54, 53, 70, 53, 53, 69, 69, 53, 54, 65, 54, 56, 56, 54, 54, 54, 69, 52, 54, 48, 66, 55, 51, 57, 69, 54, 49, 54, 52, 56, 52, 57, 50, 54, 54, 67, 68, 56, 53, 54, 51, 48, 52, 65, 57, 70, 68, 55, 65, 67, 69, 55, 57, 57, 54, 69, 48, 65, 51, 65, 56, 68, 50, 55, 69, 70, 57, 66, 54, 53, 51, 65, 53, 67, 65, 50, 56, 69, 49, 66, 50, 53, 50, 53, 54, 69, 67, 68, 69, 66, 51, 54, 67, 56, 54, 54, 52, 49, 55, 68, 66, 49, 70, 65, 65, 51, 69, 51, 50, 57, 55, 49, 50, 49, 48, 50, 50, 68, 53, 70, 69, 65, 67, 65, 49, 55, 65, 50, 51, 52, 57, 54, 66, 52, 56, 65, 66, 50, 52, 70, 65, 56, 51, 51, 67, 49, 48, 52, 67, 51, 49, 50, 65, 50, 70, 54, 57, 51, 65, 66, 54, 66, 67, 57, 52, 70, 69, 49, 67, 48, 54, 65, 65, 67, 51, 69, 56, 53, 48, 70, 65, 51, 55, 70, 51, 50, 54, 54, 66, 49 },
                            Username = "juan"
                        });
                });

            modelBuilder.Entity("MinimalBlog.Models.Entry", b =>
                {
                    b.HasOne("MinimalBlog.Models.User", "Author")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
