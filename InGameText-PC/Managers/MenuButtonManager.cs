using System;
using BeatSaberMarkupLanguage;
using BeatSaberMarkupLanguage.MenuButtons;
using InGameText.UI.FlowCoordinator;
using Zenject;

namespace InGameText.Managers
{
    internal class MenuButtonManager
    {
        private readonly MenuButton _menuButton;
        private readonly MainFlowCoordinator _mainFlowCoordinator;
        private readonly IGTFlowCoordinator _igtFlowCoordinator;

        public MenuButtonManager(MainFlowCoordinator mainFlowCoordinator, IGTFlowCoordinator igtFlowCoordinator)
        {
            _menuButton = new MenuButton("In-Game Text", "Add some fully customizable text into your game!", MenuButtonClicked);
            _mainFlowCoordinator = mainFlowCoordinator;
            _igtFlowCoordinator = igtFlowCoordinator;
        }

        public void Initialize()
        {
            MenuButtons.instance.RegisterButton(_menuButton);
        }

        public void Dispose()
        {
            if (MenuButtons.IsSingletonAvailable)
                MenuButtons.instance.UnregisterButton(_menuButton);
        }

        private void MenuButtonClicked()
        {
            _mainFlowCoordinator.PresentFlowCoordinator(_igtFlowCoordinator);
        }
    }
}
