using Playnite.FullscreenApp.ViewModels;
using Playnite.SDK;
using System;
using System.Collections.Generic;

namespace Playnite.Legacy.FullscreenApp.ViewModels
{
    public class GameClientsMenuViewModel : ObservableObject
    {
        private static readonly ILogger logger = LogManager.GetLogger();
        private readonly IWindowFactory window;
        private readonly ThirdPartyTool noClient = new ThirdPartyTool { Name = LOC.NoItemsFound.GetLocalized() };
        public FullscreenAppViewModel MainModel { get; }
        public List<ThirdPartyTool> Clients { get; }

        public RelayCommand CloseCommand => new RelayCommand(() => Close());
        public RelayCommand<ThirdPartyTool> OpenClientCommand => new RelayCommand<ThirdPartyTool>((c) =>
        {
            Close();
            if (c != noClient)
                MainModel.StartThirdPartyTool(c);
        });

        public GameClientsMenuViewModel(
            IWindowFactory window,
            FullscreenAppViewModel mainModel)
        {
            this.window = window;
            MainModel = mainModel;
            Clients = mainModel.ThirdPartyTools;
            if (Clients.Count == 0)
                Clients = new List<ThirdPartyTool> { noClient };
        }

        public bool? OpenView()
        {
            return window.CreateAndOpenDialog(this);
        }

        public void Close()
        {
            window.Close(true);
        }
    }
}
