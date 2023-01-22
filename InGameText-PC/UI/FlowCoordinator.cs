using BeatSaberMarkupLanguage;
using InGameText.UI.ViewControllers;
using Zenject;

namespace InGameText.UI.FlowCoordinator
{
    internal class IGTFlowCoordinator : HMUI.FlowCoordinator
    {
        private MainFlowCoordinator _mainFlowCoordinator = null!;
        private IGTViewController igtViewController = null!;

        [Inject]
        private void Construct(MainFlowCoordinator mainFlowCoordinator, IGTViewController _igtViewController)
        {
            _mainFlowCoordinator = mainFlowCoordinator;
            _igtViewController = igtViewController;
        }

        protected override void DidActivate(bool firstActivation, bool addedToHierarchy, bool screenSystemEnabling)
        {
            SetTitle("In-Game Text");
            showBackButton = true;

            ProvideInitialViewControllers(igtViewController);
        }

        protected override void BackButtonWasPressed(HMUI.ViewController topViewController)
        {
            _mainFlowCoordinator.DismissFlowCoordinator(this);
        }
    }
}