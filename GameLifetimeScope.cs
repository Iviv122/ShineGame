using VContainer;
using VContainer.Unity;

public class GameLifetimeScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        builder.Register<EndBus>(Lifetime.Singleton);
        builder.Register<DeathBus>(Lifetime.Singleton);
        builder.Register<InputManager>(Lifetime.Singleton);

        builder.RegisterComponentInHierarchy<ScreenEffects>();
        builder.RegisterComponentInHierarchy<LevelEnd>();
        builder.RegisterComponentInHierarchy<PlayerFreeze>();
        builder.RegisterComponentInHierarchy<PlayerDeath>();
        builder.RegisterComponentInHierarchy<DashController>();
    }
}
