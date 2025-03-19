using System.Collections.Generic;

namespace LabWork9.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private string _login;
    private string _password;
    private User _selectedUser;
    private readonly UserService _userService;
    public List<User> Users => _userService.GetUsers();

    public string Login
    {
        get => _login;
        set { _login = value; }
    }

    public string Password
    {
        get => _password;
        set { _password = value; }
    }

    public User SelectedUser
    {
        get => _selectedUser;
        set
        {
            _selectedUser = value;
            if (value != null)
            {
                Login = value.Login;
                Password = value.Password;
            }
        }
    }

    public MainViewModel()
    {
        _userService = new UserService();
    }

    public void AddUser()
    {
        _userService.AddUser(Login, Password);
    }

    public void DeleteUser()
    {
        if (SelectedUser != null)
        {
            _userService.DeleteUser(SelectedUser.Id);
        }
    }

    public void UpdateUser()
    {
        if (SelectedUser != null)
        {
            _userService.UpdateUser(SelectedUser.Id, Login, Password);
        }
    }
}