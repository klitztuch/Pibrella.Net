namespace Pibrella.Net.Model;

public class Buzzer : IOutput
{
    private readonly Pin.Buzzer _buzzer;

    public Buzzer(Pin.Buzzer buzzer)
    {
        _buzzer = buzzer;
    }

    public int Pin => (int)_buzzer;
}