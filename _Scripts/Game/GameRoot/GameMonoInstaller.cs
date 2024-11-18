using UnityEngine;
using WinterEvening._Scripts.Utils;
using Zenject;

namespace WinterEvening._Scripts.Game.GameRoot
{
    public class GameMonoInstaller : MonoInstaller
    {
        
        public override void InstallBindings()
        {
            Container.Bind<SceneLoader>().ToSelf().AsSingle();
            Container.Bind<GameEntryPoint>().AsSingle();
        }

        public override void Start()
        {
            base.Start();
            Container.Resolve<GameEntryPoint>().Run();
        }
    }
}