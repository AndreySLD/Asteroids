using Asteroids.Abstrac_Factory;

namespace Asteroids
{
    public interface IPlatform
    {
        IInput Input { get; }
        IWindow Window { get; }
    }
}