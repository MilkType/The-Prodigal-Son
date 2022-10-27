using DSharpPlus.Entities;
using DSharpPlus.SlashCommands;
using System.Diagnostics.Metrics;
using The_Prodigal_Son.Utilities;

namespace The_Prodigal_Son.PTU
{
    public class PTU_Resources
    {
        public static string ReadCtx(InteractionContext ctx, string[] args)
        {
            var who = ctx.Member.DisplayName;
            var command = ctx.CommandName;
            var what = "";

            if (args.Length == 1) { var p1 = args[0]; what += p1; } ;
            if (args.Length == 2) { var p2 = args[1]; what += " and " + p2; };

            return who + " called " + command + " with: " + what;
        }

        public static async void LogStep(InteractionContext ctx, string msg)
        {
            var logID = DotEnv.FetchLogID();
            var logchannel = ctx.Guild.Channels[logID];
            await logchannel.SendMessageAsync(msg);
        }

        public static async void LogStart(InteractionContext ctx, string[] args)
        {
            var msg = ReadCtx(ctx, args);

            var logID = DotEnv.FetchLogID();
            try { DiscordChannel logchannel = ctx.Guild.Channels[logID]; await logchannel.SendMessageAsync(msg); }
            catch { return; }
 
            
        }
    
    }
}
