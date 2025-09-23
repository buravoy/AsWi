using HSx.Components.Pages.AdminShared;
using Microsoft.AspNetCore.Components;

namespace HSx.Components.Pages;

public partial class Admin : ComponentBase
{
    private bool _isLoggedIn;
    private const string User =  "admin";
    private const string Password = "123123";

    private void HandleLogin(LoginForm.AuthData data)
    {
        if (data is { Login: User, Password: Password })
        {
            _isLoggedIn = true;
        }
    }
}
