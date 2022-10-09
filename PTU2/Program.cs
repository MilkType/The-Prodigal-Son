using The_Prodigal_Son.Bot;
using The_Prodigal_Son.Utilities;

//Load .env
var root = Directory.GetCurrentDirectory();
var dotenv = Path.Combine(root, ".env");
DotEnv.Load(dotenv);

//Start Bot
var bot = new Bot();
bot.RunAsync().GetAwaiter().GetResult();