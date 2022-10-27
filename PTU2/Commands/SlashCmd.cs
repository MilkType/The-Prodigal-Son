using DSharpPlus.Entities;
using DSharpPlus;
using DSharpPlus.SlashCommands;
using The_Prodigal_Son.Data;
using static The_Prodigal_Son.PTU.PTU_Resources;
using static The_Prodigal_Son.Utilities.DotEnv;

namespace The_Prodigal_Son.Commands
{
    public class SlashCmd : ApplicationCommandModule
    {
        public static PTU_DBContext PTUDB = new PTU_DBContext();

        [SlashCommand("Ping", "Pong!")]
        public async Task Ping(InteractionContext ctx)
        {
            string[] args = new string[] { };
            LogStart(ctx, args);
            await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent("Success!"));
        }
    }
}
