namespace Pibrella.Net.Model;

public class Light : IOutput
{
    private readonly Pin.Light _light;
    public int Pin => (int)_light;
    
    public Light(Pin.Light light)
    {
        _light = light;
    }
}