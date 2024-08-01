using NewsApp.ViewModels;

namespace NewsApp;

public class Nagivator : INavigate
{
    public async Task NavigateTo(string route) => await Shell.Current.GoToAsync(route);

    public async Task PushModal(Page page) => await Shell.Current.Navigation.PushModalAsync(page);

    public async Task PopModal() => Shell.Current.Navigation.PopModalAsync();
}