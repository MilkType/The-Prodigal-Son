using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Util.Store;
using The_Prodigal_Son.Bot;
using The_Prodigal_Son.Utilities;

//Load .env
#region .env
var root = Directory.GetCurrentDirectory();
var dotenv = Path.Combine(root, ".env");
DotEnv.Load(dotenv);
#endregion .env

//Instantiate Bot
var bot = new Bot();
bot.RunAsync().GetAwaiter().GetResult();