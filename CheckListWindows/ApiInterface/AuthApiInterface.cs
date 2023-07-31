using CheckListWindows.ApiInterface;
using CheckListWindows.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CheckListWindows.apiInterface
{
    class AuthApiInterface
    {
        private static String username = ConfigurationManager.AppSettings.Get("username");
        private static String password = ConfigurationManager.AppSettings.Get("password");

        private static HttpClient client = new HttpClient();

        public static String getChecklistToken()
        {

            username = ConfigurationManager.AppSettings.Get("username");
            password = ConfigurationManager.AppSettings.Get("password");

            String uri = config.authApiUrl + "/Auth/checkListToken";
            client = new HttpClient();

            client.DefaultRequestHeaders.Add("username", username);
            client.DefaultRequestHeaders.Add("password", password);

            SaveConfigInterface.AddOrUpdateAppSettings("checklistToken", "NONE");



            var task = Task.Run(() => client.GetAsync(uri));
            var response = task.Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                String generatedToken = response.Content.ReadAsStringAsync().Result;
                SaveConfigInterface.AddOrUpdateAppSettings("checklistToken", generatedToken);
                return "Token generated";
            }

            return response.StatusCode.ToString();
        }

        public static String createUser(String pinCode, AuthUserDto newUser)
        {
            String uri = config.authApiUrl + "/Auth";
            client = new HttpClient();

            client.DefaultRequestHeaders.Add("invite", pinCode);

            var jsonContent = JsonConvert.SerializeObject(newUser);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            contentString.Headers.ContentType = new
            MediaTypeHeaderValue("application/json");

            var task = Task.Run(() => client.PostAsync(uri, contentString));
            var response = task.Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                String generatedToken = response.Content.ReadAsStringAsync().Result;
                SaveConfigInterface.AddOrUpdateAppSettings("checklistToken", generatedToken);
                return "Token generated";
            }

            return "Placeholder - User generated";
        }

        public static bool isUserInserted()
        {
            if(ConfigurationManager.AppSettings.Get("username") == "" || ConfigurationManager.AppSettings.Get("password") == "")
            {
                return false;
            }
            return true;
        }

    }
}
