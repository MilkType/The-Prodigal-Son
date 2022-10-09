using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.EventArgs;

namespace The_Prodigal_Son.Bot
{
    public class Bot
    {

        public DiscordClient Client { get; private set; }
        public CommandsNextExtension Commands { get; private set; }

        public async Task RunAsync()
        {
            var config = new DiscordConfiguration
            {
                Token = Environment.GetEnvironmentVariable("Token"),
                TokenType = TokenType.Bot,
                AutoReconnect = true,
                MinimumLogLevel = Microsoft.Extensions.Logging.LogLevel.Debug
            };

            Client = new DiscordClient(config);

            Client.Ready += OnReady;

            var commandConfig = new CommandsNextConfiguration
            {
                StringPrefixes = new string[] { Environment.GetEnvironmentVariable("Prefix") },
                EnableMentionPrefix = true,
                EnableDms = true,
                DmHelp = true
            };

            Commands = Client.UseCommandsNext(commandConfig);

            //Commands.RegisterCommands<FunCommands>();

            //Commands.RegisterCommands<TestCommands>();

            await Client.ConnectAsync();

            await Task.Delay(-1);
        }

        private Task OnReady(DiscordClient client, ReadyEventArgs e)
        {
            return Task.CompletedTask;
        }
    }
}
