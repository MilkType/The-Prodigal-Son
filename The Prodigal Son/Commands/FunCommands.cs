using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using System.Threading.Tasks;

namespace The_Prodigal_Son.Commands
{
    internal class FunCommands : BaseCommandModule
    {
        [Command("Hello")]
        public async Task Hello(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Hello there!").ConfigureAwait(false);
        }
    }
}
