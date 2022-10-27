using DSharpPlus;
using DSharpPlus.Entities;
using DSharpPlus.EventArgs;
using DSharpPlus.SlashCommands;
using The_Prodigal_Son.Commands;
using The_Prodigal_Son.Data;
using static The_Prodigal_Son.Utilities.DotEnv;


namespace The_Prodigal_Son.Bot
{
    public class Bot
    {

        public DiscordClient? client { get; private set; }
        public SlashCommandsExtension? slash { get; private set; }

        public async Task RunAsync()
        {
            var config = new DiscordConfiguration
            {
                Token = Fetch("Token"),
                TokenType = TokenType.Bot,
                AutoReconnect = true,
                MinimumLogLevel = Microsoft.Extensions.Logging.LogLevel.Debug
            };

            client = new DiscordClient(config);

            client.Ready += OnReady;

            slash = client.UseSlashCommands();
            
            slash.RegisterCommands<SlashTstCmd>(806718602380181594);

            await client.ConnectAsync();

            await Task.Delay(-1);
        }

        private Task OnReady(DiscordClient client, ReadyEventArgs e)
        {
            return Task.CompletedTask;
        }
    }
}
