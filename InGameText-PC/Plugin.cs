using IPA;
using IPA.Config;
using IPA.Config.Stores;
using InGameText.Configuration;
using InGameText.Installers;
using SiraUtil.Zenject;
using IPALogger = IPA.Logging.Logger;

namespace InGameText
{
    [Plugin(RuntimeOptions.DynamicInit)]
    [NoEnableDisable]
    public class Plugin
    {
        [Init]
        public void Init(Config config, IPALogger logger, Zenjector zenjector)
        {
            zenjector.UseSiraSync();
            zenjector.UseLogger(logger);
            zenjector.UseMetadataBinder<Plugin>();

            zenjector.Install<MenuInstaller>(Location.Menu, config.Generated<InGameTextConfig>());
            zenjector.Install<GameInstaller>(Location.StandardPlayer | Location.MultiPlayer);
        }
    }
}
