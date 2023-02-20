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
        List<User> users = new();

        public UserService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<User>> GetUsers()
        {
            if (users.Count > 0)
                return users;

            HttpResponseMessage response = await _httpClient.GetAsync("https://localhost:5001/api/users");

            if (response.IsSuccessStatusCode)
            {
                users = await response.Content.ReadFromJsonAsync<List<User>>();
            }

            return users;
        }
    }
}

