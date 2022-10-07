using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;
using DSharpPlus.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace The_Prodigal_Son.Commands
{
    internal class TestCommands : BaseCommandModule
    {

        [Command("Ping")]
        public async Task Ping(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("Testing Response!").ConfigureAwait(false);
        }

        [Command("Test")]
        public async Task Test(CommandContext ctx)
        {
            var logchannel = ctx.Guild.Channels[1027699511008690206];
            await ctx.Channel.SendMessageAsync("Testing Channels!\n").ConfigureAwait(false);
        }
    }
}

