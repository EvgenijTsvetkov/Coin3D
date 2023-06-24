using UnityEngine;
using Zenject;

namespace Coin.Source
{
    public class MainInstaller : MonoInstaller
    {
        [SerializeField] private Camera _camera;
        [SerializeField] private InputService _inputService;
        [SerializeField] private PirateCoin _pirateCoin;
        
        public override void InstallBindings()
        {
            BindInputService();
            BindPhysicsCaster();
            
            BindMainCameraProvider();
            BindMainCamera();

            InjectForCoin();
        }

        private void BindInputService()
        {
            Container.Bind<IInputService>().FromInstance(_inputService).AsSingle();
        }
        
        private void BindPhysicsCaster()
        {
            Container.Bind<IPhysicsCaster>().To<PhysicsCaster>().AsSingle();
        }

        private void BindMainCameraProvider()
        {
            Container.Bind<IMainCameraProvider>().To<MainCameraProvider>().AsSingle();
        }
        
        private void BindMainCamera()
        {
            IMainCameraProvider mainCameraProvider = Container.Resolve<IMainCameraProvider>();
            mainCameraProvider.Value = _camera;
        }
        
        private void InjectForCoin()
        {
            Container.Inject(_pirateCoin);
        }
    }
}