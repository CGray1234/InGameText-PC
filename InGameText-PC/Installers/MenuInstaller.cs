using InGameText.Configuration;
using InGameText.UI.FlowCoordinator;
using InGameText.UI.ViewControllers;
using InGameText.Managers;
using BeatSaberMarkupLanguage.MenuButtons;
using Zenject;

namespace InGameText.Installers
{
    internal class MenuInstaller : Installer
    {
        private readonly InGameTextConfig _config;

        public MenuInstaller(InGameTextConfig config)
        {
            _config = config;
        }

        public override void InstallBindings()
        {
            Container.BindInstance(_config);
            Container.BindInterfacesTo<MenuButtonManager>().AsSingle();
            Container.Bind<IGTFlowCoordinator>().FromNewComponentOnNewGameObject().AsSingle();
            Container.Bind<IGTViewController>().FromNewComponentAsViewController().AsSingle();
        }
    }
}
