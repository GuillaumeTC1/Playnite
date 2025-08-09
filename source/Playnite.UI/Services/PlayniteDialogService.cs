using Microsoft.AspNetCore.Components;

namespace Playnite.UI.Services
{
    public interface IPlayniteDialogService
    {
        Task<bool> ShowConfirmation(string title, string message);
        Task<TResult> ShowDialog<TResult>(string title, RenderFragment content);
        Task ShowMessage(string title, string message);
    }

    public class PlayniteDialogService : IPlayniteDialogService
    {
        private readonly NavigationManager _navigationManager;

        public PlayniteDialogService(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }

        public async Task<bool> ShowConfirmation(string title, string message)
        {
            // Implementation will be added once we have the dialog component
            return await Task.FromResult(false);
        }

        public async Task<TResult> ShowDialog<TResult>(string title, RenderFragment content)
        {
            // Implementation will be added once we have the dialog component
            return default;
        }

        public async Task ShowMessage(string title, string message)
        {
            // Implementation will be added once we have the dialog component
            await Task.CompletedTask;
        }
    }
}
