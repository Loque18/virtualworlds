using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "settingsInstaller", menuName = "Installers/settingsInstaller")]
public class settingsInstaller : ScriptableObjectInstaller<settingsInstaller>
{
    private AppSettings1 gameSettings;

    public override void InstallBindings()
    {
        Container.BindInterfacesAndSelfTo<AppSettings1>().AsSingle();
    }
}