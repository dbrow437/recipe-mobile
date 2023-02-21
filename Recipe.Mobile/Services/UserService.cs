using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using Recipe.Mobile.Models;

namespace Recipe.Mobile.Services
{
    //TODO: implement error handeling
	public class UserService
	{
        HttpClient _httpClient;

        public List<User> Users { get; private set; }

        public UserService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<User>> GetUsers()
        {
            Users = new();
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("https://localhost:5001/api/users");

                if (response.IsSuccessStatusCode)
                {
                    Users = await response.Content.ReadFromJsonAsync<List<User>>();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tError {0}", ex.Message);
            }

            return Users;
        }
    }
}

