using DSharpPlus;
using DSharpPlus.Entities;
using DSharpPlus.SlashCommands;
using The_Prodigal_Son.Data;
using The_Prodigal_Son.PTU;
using The_Prodigal_Son.Utilities;
using static The_Prodigal_Son.PTU.PTU_Resources;
using static The_Prodigal_Son.Utilities.DotEnv;


namespace The_Prodigal_Son.Commands
{
    public class SlashTstCmd : ApplicationCommandModule
    {
        public static GoogleSheetsHelper sheetsService = new GoogleSheetsHelper();
            
        public static PTU_DBContext PTUDB = new PTU_DBContext();

        [SlashCommand("LogTest", "A slash command made to test logging to discord log channel!")]
        public async Task LogTest(InteractionContext ctx) 
        {
            string[] args = new string[] {};
            LogStart(ctx, args);
            await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent("Success!"));
        }

        [SlashCommand("ModeTest", "A slash command made to test switching modes!")]
        public async Task ModeTest(InteractionContext ctx, [Option("mode", "Mode to switch to")] string newmode)
        {
            string[] args = new string[] { newmode };
            LogStart(ctx, args);
            var mode = newmode;
            var result = SetMode(mode);
            LogStep(ctx, result);
            await Messages.SendNormal(ctx, result);
        }

        [SlashCommand("PlayersTest", "A slash command made to list players!")]
        public async Task PlayersTest(InteractionContext ctx, [Option("stat", "Stat to roll!")] string stat)
        {
            string[] args = new string[] { stat };
            LogStart(ctx, args);
            var result1 = PTUDB.Players;
            var result2 = result1.ToList();
            var result = "Players found:\n" + String.Join("\n", result2.Select(x => x.DiscordId));
            LogStep(ctx, result);
            await Messages.SendNormal(ctx, result);
        }

        [SlashCommand("DexTest", "A slash command made to return a pokemon!")]
        public async Task DexTest(InteractionContext ctx, [Option("poke", "Pokemon to get!")] string poke)
        {
            string[] args = new string[] { poke };
            LogStart(ctx, args);
            var result_name = PTUDB.Pokedex.Single(n => n.PokemonName.Contains(poke)).PokemonName.ToString();
            var result = "Pokemon found: " + result_name;
            LogStep(ctx, result);
            await Messages.SendNormal(ctx, result);
        }

        [SlashCommand("SheetTest", "A slash command made to check a sheet!")]
        public async Task SheetTest(InteractionContext ctx, [Option("link", "Sheet to check!")] string link)
        {
            var sheets = await sheetsService.GetSheetsServiceAsync();
            string[] args = new string[] { link };
            LogStart(ctx, args);
            var result = sheets.Spreadsheets.Values.BatchGet(link).ToString();
            Console.WriteLine(result);
            LogStep(ctx, result);
            await Messages.SendNormal(ctx, result);
        }
    }
}
