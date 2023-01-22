using InGameText.UI.ViewControllers;
using InGameText.Configuration;
using Zenject;

namespace InGameText.Installers
{
    internal class GameInstaller : Installer<GameInstaller>
    {
        private readonly InGameTextConfig _config;

        public GameInstaller(InGameTextConfig config)
        {
            _config = config;
        }

        public override void InstallBindings()
        {
            if (!_config.TextEnabled)
            {
                return;
            }

            Container.BindInterfacesAndSelfTo<TextViewController>().FromNewComponentAsViewController().AsSingle();
        }
    }
}
