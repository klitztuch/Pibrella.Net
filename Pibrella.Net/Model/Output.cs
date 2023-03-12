namespace Pibrella.Net.Model;

public class Output : IOutput
{
    private readonly Pin.Output _output;

    public Output(Pin.Output output)
    {
        _output = output;
    }

    public int Pin => (int)_output;
}