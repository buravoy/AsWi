using Microsoft.AspNetCore.Components;

namespace HSx.Components.Pages.AdminShared;

public partial class LoginForm : ComponentBase
{
    [Parameter]
    public EventCallback<AuthData> OnLogin { get; set; }

    private string _login = String.Empty;
    private string _password = String.Empty;

    public class AuthData
    {
        public required string Login;
        public required string Password;
    }

    private async Task Login()
    {
        await OnLogin.InvokeAsync(new AuthData
        {
            Login =  _login,
            Password = _password
        });
    }
}
