using LeaderboardApp.Models;

public class AppState
{
    public Users? CurrentUser { get; set; }
    public bool IsLoggedIn => CurrentUser != null;
    public bool IsAdmin => CurrentUser?.Role == "admin";

    public event Action? OnChange;

    public void SetUser(Users user)
    {
        CurrentUser = user;
        OnChange?.Invoke();
    }

    public void Logout()
    {
        CurrentUser = null;
        OnChange?.Invoke();
    }
}