namespace Pibrella.Net.Model;

public class Button : IInput
{
    private readonly Pin.Button _pin;

    public Button(Pin.Button pin)
    {
        _pin = pin;
    }

    public int Pin => (int)_pin;
}