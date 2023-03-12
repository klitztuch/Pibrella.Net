namespace Pibrella.Net.Model;

public class Input : IInput
{
    private readonly Pin.Input _input;
    public int Pin => (int)_input;
    
    public Input(Pin.Input input)
    {
        _input = input;
    }
}