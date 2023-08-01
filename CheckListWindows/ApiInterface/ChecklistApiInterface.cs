using CheckListWindows.Models;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CheckListWindows.ApiInterface
{
    class ChecklistApiInterface
    {
        private static HttpClient client = new HttpClient();

        private static String checklistToken = ConfigurationManager.AppSettings.Get("checklistToken");

        public static List<ShowChecklistItemDto> getListItens(int listId)
        {
            checklistToken = ConfigurationManager.AppSettings.Get("checklistToken");

            List<ShowChecklistItemDto> showChecklistItems = new List<ShowChecklistItemDto>();
            List<ShowChecklistNameDto> showListNames = new List<ShowChecklistNameDto>();
            List<ChecklistItemDto> checklistItems = new List<ChecklistItemDto>();


            String uri = config.checklistApiUrl + "/checklists/getCheckListItems";
            client = new HttpClient();

            client.DefaultRequestHeaders.Add("token", checklistToken);
            client.DefaultRequestHeaders.Add("listId", listId.ToString());

            var task = Task.Run(() => client.GetAsync(uri));
            var response = task.Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var responseList = response.Content.ReadAsStringAsync().Result;
                try
                {
                    checklistItems = JsonConvert.DeserializeObject<List<ChecklistItemDto>>(responseList);
                    showChecklistItems = createItems(checklistItems);
                }
                catch (Exception ex)
                {
                    string exception = ex.Message;
                }

                return showChecklistItems;
            }

            return showChecklistItems;
        }

        public static List<CheckedItemDto> GetCheckedItems(int listId)
        {
            checklistToken = ConfigurationManager.AppSettings.Get("checklistToken");

            List<CheckedItemDto> listItens = new List<CheckedItemDto>();
            for (int i = 1; i <= 5; i++)
            {
                CheckedItemDto mockcheckedItem = new CheckedItemDto();
                mockcheckedItem.id = i;
                mockcheckedItem.checklistItemId = i;
                mockcheckedItem.checklistId = listId;
                listItens.Add(mockcheckedItem);
            }

            return listItens;
        }


        public static List<ShowChecklistNameDto> getMineListNames()
        {
            checklistToken = ConfigurationManager.AppSettings.Get("checklistToken");
            List<ShowChecklistNameDto> showListNames = new List<ShowChecklistNameDto>();
            List<ChecklistNameDto> listNames = new List<ChecklistNameDto>();


            String uri = config.checklistApiUrl + "/checklists/getOwnedCheckList";
            client = new HttpClient();

            client.DefaultRequestHeaders.Add("token", checklistToken);

            var task = Task.Run(() => client.GetAsync(uri));
            var response = task.Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var responseList = response.Content.ReadAsStringAsync().Result;
                try
                {
                    listNames = JsonConvert.DeserializeObject<List<ChecklistNameDto>>(responseList);
                    showListNames = createListNames(listNames);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return showListNames;
            }

            return showListNames;
        }



        public static List<ShowChecklistNameDto> getListNames()
        {
            checklistToken = ConfigurationManager.AppSettings.Get("checklistToken");
            List<ShowChecklistNameDto> showListNames = new List<ShowChecklistNameDto>();
            List<ChecklistNameDto> listNames = new List<ChecklistNameDto>();


            String uri = config.checklistApiUrl + "/checklists/getCheckList";
            client = new HttpClient();

            client.DefaultRequestHeaders.Add("token", checklistToken);

            var task = Task.Run(() => client.GetAsync(uri));
            var response = task.Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var responseList = response.Content.ReadAsStringAsync().Result;
                try
                {
                    listNames = JsonConvert.DeserializeObject< List<ChecklistNameDto>>(responseList);
                    showListNames = createListNames(listNames);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return showListNames;
            }
            else
            {
                Console.WriteLine(response.StatusCode.ToString());
            }

            return showListNames;
        }

        public static List<ChecklistNameDto> getOwnedLists()
        {
            checklistToken = ConfigurationManager.AppSettings.Get("checklistToken");
            List<ChecklistNameDto> listNames = new List<ChecklistNameDto>();


            String uri = config.checklistApiUrl + "/checklists/getOwnedCheckList";
            client = new HttpClient();

            client.DefaultRequestHeaders.Add("token", checklistToken);

            var task = Task.Run(() => client.GetAsync(uri));
            var response = task.Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var responseList = response.Content.ReadAsStringAsync().Result;
                try
                {
                    listNames = JsonConvert.DeserializeObject<List<ChecklistNameDto>>(responseList);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return listNames;
            }
            else
            {
                Console.WriteLine(response.StatusCode.ToString());
            }
            return listNames;
        }

        public static List<ShowChecklistNameDto> getMockListNames()
        {
            checklistToken = ConfigurationManager.AppSettings.Get("checklistToken");
            List<ShowChecklistNameDto> listNames = new List<ShowChecklistNameDto>();



            for (int i = 1; i <= 5; i++)
            {
                ShowChecklistNameDto mockShowList = new ShowChecklistNameDto();
                ChecklistNameDto mockListName = new ChecklistNameDto();
                mockListName.id = i;
                mockListName.name = "List " + i.ToString();

                mockShowList.chkItens = 1;
                mockShowList.numItens = 5;
                mockShowList.isActive = false;
                mockShowList.checklist = mockListName;

                listNames.Add(mockShowList);
            }

            return listNames;
        }


        private static List<ShowChecklistItemDto> createItems(List<ChecklistItemDto> responseList)
        {
            List<ShowChecklistItemDto> showListItems = new List<ShowChecklistItemDto>();

            foreach (ChecklistItemDto list in responseList)
            {
                ShowChecklistItemDto showChecklistItem = new ShowChecklistItemDto();
                showChecklistItem.checkItem = list;

                showListItems.Add(showChecklistItem);
            }

            return showListItems;
        }

        private static List<ShowChecklistNameDto> createListNames(List<ChecklistNameDto> responseList)
        {
            List<ShowChecklistNameDto> showListNames = new List<ShowChecklistNameDto>();

            foreach(ChecklistNameDto list in responseList)
            {
                ShowChecklistNameDto showChecklistName = new ShowChecklistNameDto();
                showChecklistName.checklist = list;
                showChecklistName.isActive = false;
                showChecklistName.isOwned = false;
                showChecklistName.numItens = 0;
                showChecklistName.chkItens = 0;

                showListNames.Add(showChecklistName);
            }

            return showListNames;
        }

        public static bool createNewList(ChecklistNameDto newChecklist)
        {
            checklistToken = ConfigurationManager.AppSettings.Get("checklistToken");
            List<ShowChecklistNameDto> listNames = new List<ShowChecklistNameDto>();

            String uri = config.checklistApiUrl + "/checklists/addList";

            client.DefaultRequestHeaders.Remove("token");
            client.DefaultRequestHeaders.Add("token", checklistToken);

            var jsonContent = JsonConvert.SerializeObject(newChecklist);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            contentString.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var task = Task.Run(() => client.PostAsync(uri, contentString));
            var response = task.Result;

            if (response.StatusCode == HttpStatusCode.Created)
            {
                return true;
            }

            return false;
        }

        public static bool createNewItem(CheckedItemDto newItem)
        {
            // Corrigir
            checklistToken = ConfigurationManager.AppSettings.Get("checklistToken");
            String uri = config.checklistApiUrl + "/checklists/addItem";

            client.DefaultRequestHeaders.Remove("token");
            client.DefaultRequestHeaders.Add("token", checklistToken);

            var jsonContent = JsonConvert.SerializeObject(newItem);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            contentString.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var task = Task.Run(() => client.PostAsync(uri, contentString));
            var response = task.Result;

            if (response.StatusCode == HttpStatusCode.Created)
            {
                return true;
            }

            return false;
        }

        public static List<ShowChecklistItemDto> getMockListItens(int listId)
        {
            List<ShowChecklistItemDto> showChecklistItems = new List<ShowChecklistItemDto>();
            for (int i = 1; i <= 5; i++)
            {
                ShowChecklistItemDto showChecklistItem = new ShowChecklistItemDto();
                ChecklistItemDto mockListItem = new ChecklistItemDto();
                mockListItem.id = i;
                mockListItem.name = "Item " + i.ToString();
                mockListItem.checklistId = listId;
                showChecklistItem.checkItem = mockListItem;

                showChecklistItems.Add(showChecklistItem);
            }
            return showChecklistItems;
        }

        public static bool checkItem(ChecklistItemDto newItem)
        {
            checklistToken = ConfigurationManager.AppSettings.Get("checklistToken");
            String uri = config.checklistApiUrl + "/checklists/checkItem";

            client.DefaultRequestHeaders.Remove("token");
            client.DefaultRequestHeaders.Add("token", checklistToken);

            var jsonContent = JsonConvert.SerializeObject(newItem);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            contentString.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var task = Task.Run(() => client.PostAsync(uri, contentString));
            var response = task.Result;

            if (response.StatusCode == HttpStatusCode.Created)
            {
                return true;
            }

            return false;
        }

        public static string generatePinCode(ChecklistNameDto shareChecklist)
        {
            checklistToken = ConfigurationManager.AppSettings.Get("checklistToken");
            String uri = config.checklistApiUrl + "/checklists/shareList";

            client.DefaultRequestHeaders.Remove("token");
            client.DefaultRequestHeaders.Add("token", checklistToken);

            var jsonContent = JsonConvert.SerializeObject(shareChecklist);
            var contentString = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            contentString.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var task = Task.Run(() => client.PostAsync(uri, contentString));
            var response = task.Result;

            if (response.StatusCode == HttpStatusCode.Created)
            {
                var responseList = response.Content.ReadAsStringAsync().Result;
                return responseList.ToString();
            }

            return "PinCode Error";
        }

        public static bool AddSharedList(string pinCode)
        {
            checklistToken = ConfigurationManager.AppSettings.Get("checklistToken");


            String uri = config.checklistApiUrl + "/checklists/addSharedList";
            client = new HttpClient();

            client.DefaultRequestHeaders.Add("token", checklistToken);
            client.DefaultRequestHeaders.Add("pinCode", pinCode);

            var task = Task.Run(() => client.GetAsync(uri));
            var response = task.Result;

            if (response.StatusCode == HttpStatusCode.Created)
            {
                return true;
            }

            return false;
        }

        public static bool RemoveList(ShowChecklistNameDto removedList)
        {
            if (!removedList.isOwned)
            {
                return false;
            }
            checklistToken = ConfigurationManager.AppSettings.Get("checklistToken");


            String uri = config.checklistApiUrl + "/checklists/removeList";
            client = new HttpClient();

            client.DefaultRequestHeaders.Add("token", checklistToken);
            client.DefaultRequestHeaders.Add("listId", removedList.checklist.id.ToString());

            var task = Task.Run(() => client.GetAsync(uri));
            var response = task.Result;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }




            return false;
        }


    }
}
