using System;
using Recipe.Mobile.Models;
using Recipe.Mobile.Services;

namespace Recipe.Mobile.ViewModels
{
	public partial class UserViewModel : ObservableObject
	{
		//[ObservableProperty]
		//private ObservableCollection<User> _users;
		private UserService _userService;

		public UserViewModel(UserService userService)
		{
			_userService = userService;
			//_users = new ObservableCollection<User>(_userService.GetUsers());
		}

		async Task<List<User>> GetUsers()
		{
			List<User> users = new();
			try
			{
				users = await _userService.GetUsers();
            }
			catch (Exception ex)
			{
				Debug.WriteLine($"Unable to get users: {ex:Message}");
				await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");
			}

			return users;
		}
	}
		
}

