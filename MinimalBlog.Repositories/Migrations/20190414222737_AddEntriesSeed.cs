using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MinimalBlog.Repositories.Migrations
{
    public partial class AddEntriesSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Entrys",
                columns: new[] { "Id", "Content", "Created", "Image", "State", "Summary", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "Just as the Bolton men found Sansa and Theon Greyjoy – whom helped her escape from Winterfell in the last episode of season 5 of HBO’s Game of Thrones – and were about to take them back to Ramsay – who would surely punish them severally – Brienne charged in on horseback and took them out with Oathkeeper – the Valyrian steel sword that Jaime Lannister gave her to rescue the Stark girls with.Sansa knighted Brienne, with the help of Theon Greyjoy, like her mother did before her and took her into her service as her sworn sword and shield.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.ablogofthrones.com/wp-content/uploads/2018/01/Sansa-Knights-Brienne-1920x1079.jpg", 0, "Having just missed Sansa Stark’s signal, Brienne of the Tarth and her squire – Podrick Payne – went in search of her after she escaped her abusive husband, Ramsay Bolton.", "Brienne’s Rescue Of Sansa & Being Knighted", 1 },
                    { 2, "Jeor explained the history behind the sword and who it belonged to, and who is was meant for, before offering it to Jon. He tries to refuse, but Jeor tells him that he has earnt it by saving his life.It emphasises the respect and gratitude that Jon earnt for his heroic act, and emphasises that he is a hero – possibly the overall hero of the entire series.", new DateTime(2019, 4, 13, 22, 27, 36, 986, DateTimeKind.Utc).AddTicks(7538), "https://www.ablogofthrones.com/wp-content/uploads/2018/01/Jeor-Mormont-Offers-Longclaw-To-Jon-Snow-1920x1080.jpg", 2, "Having saved Jeor Mormont from one of the undead, Jon Snow was gifted with Longclaw – the ancestral Valyrian steel sword of House Mormont. He reveals that he had a new pommel made in the form of a wolf rather than a bear, to honour House Stark – the House of Jon’s believed to be father, Ned Stark.", "Jeor Mormont Offers Longclaw To Jon Snow", 1 },
                    { 3, "The Nights Watch Brother followed his command and dropped it. The large, anchor looking metal weapon was dropped from the top of the Wall and left to swing across the side. The large, metal weapon scraped into the Wall as it did so and took out all of the Wildlings.They screamed and cried out as it crushed them and knocked them from the Wall.", new DateTime(2019, 4, 12, 22, 27, 36, 986, DateTimeKind.Utc).AddTicks(7575), "https://www.ablogofthrones.com/wp-content/uploads/2018/01/Nights-Watch-Drops-The-Sycthe-1920x1079.jpg", 0, "As the Wildlings were climbing the Wall, Ed gave the order for the Scythe to be dropped in order to prevent them from crossing the Wall and venturing south to raid and kill people.", "The Nights Watch Drops The Scythe", 1 },
                    { 4, null, new DateTime(2019, 4, 12, 22, 27, 36, 986, DateTimeKind.Utc).AddTicks(7596), null, 1, null, "Title here", 1 },
                    { 5, "After pouring herself a glass of red wine and sitting in her chair in a seductive manner, she told Daario to take off his clothes since that was what he did best.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://www.ablogofthrones.com/wp-content/uploads/2018/01/Daenerys-Daario-Bedroom-1920x1079.jpg", 0, "Having not had a romantic or sexual partner since season 1 of HBO’s Game of Thrones, Daenerys Targaryen gave into her desires in season 4 when Daario Naharis – whom she had chemistry and tension with since meeting – came to her chambers.", "Daenerys Getting Laid On Her Own Terms", 2 },
                    { 6, "She and Jon Snow were standing atop the cliffs of Dragonstone when the Dothraki told her that a man claiming to be her friend was there. She turned to see Jorah behind them. Daenerys looks ready to cry at the sight of her longest and most trusted friend.She informs Jon Snow of who he is and he tells Jorah that his father was a great man.Jorah offers Daenerys his service, if she will have him.She then tells him it will be her honour and then embraces him warmly and affectionately.", new DateTime(2019, 4, 13, 22, 27, 36, 986, DateTimeKind.Utc).AddTicks(9081), "https://www.ablogofthrones.com/wp-content/uploads/2018/01/Daenerys-Takes-Jorah-Back-1920x1080.jpg", 2, "After having had an emotional goodbye with Jorah in which he confesses his love for her, Jorah returned to Daenerys after getting rid of the Greyscale that he contracted while sailing through old Valyria.", "Jorah Is Greeted Back By Daenerys", 2 },
                    { 7, null, new DateTime(2019, 4, 12, 22, 27, 36, 986, DateTimeKind.Utc).AddTicks(9183), null, 1, null, "Very good draft", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Entrys",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Entrys",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Entrys",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Entrys",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Entrys",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Entrys",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Entrys",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
