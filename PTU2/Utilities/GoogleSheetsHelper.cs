using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;

namespace The_Prodigal_Son.Utilities
{
    public class GoogleSheetsHelper
    {
        public SheetsService sheets { get; private set; }
        public async Task<SheetsService> GetSheetsServiceAsync() 
        {
            var credential =
                    await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromFile("token.json").Secrets,
                    new[] { SheetsService.Scope.Spreadsheets },
                    "user", CancellationToken.None);

            sheets = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "The Prodigal Son",
            });
            return sheets;
        }
    }
}
