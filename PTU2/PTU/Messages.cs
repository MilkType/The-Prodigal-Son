using DSharpPlus.Entities;
using DSharpPlus;
using DSharpPlus.SlashCommands;

namespace The_Prodigal_Son.PTU
{
    public static class Messages
    {
        public static async Task SendNormal(InteractionContext ctx, string msg)
        {
            await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent(msg));
        }
    }
}
