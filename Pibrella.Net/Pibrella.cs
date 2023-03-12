using Pibrella.Net.Model;

namespace Pibrella.Net;

public class Pibrella : IPibrella
{
    public Pibrella()
    {
        Red = new Light(Model.Pin.Light.Red);
        Yellow = new Light(Model.Pin.Light.Yellow);
        Green = new Light(Model.Pin.Light.Green);
        Lights = new[] { Red, Yellow, Green };

        InputA = new Input(Model.Pin.Input.A);
        InputB = new Input(Model.Pin.Input.B);
        InputC = new Input(Model.Pin.Input.C);
        InputD = new Input(Model.Pin.Input.D);
        Inputs = new[] { InputA, InputB, InputC, InputD };

        OutputA = new Output(Model.Pin.Output.A);
        OutputB = new Output(Model.Pin.Output.B);
        OutputC = new Output(Model.Pin.Output.C);
        OutputD = new Output(Model.Pin.Output.D);
        Outputs = new[] { OutputA, OutputB, OutputC, OutputD };

        Button = new Button(Model.Pin.Button.Button);

        Buzzer = new Buzzer(Model.Pin.Buzzer.Buzzer);
    }

    public Light Red { get; set; }
    public Light Yellow { get; set; }
    public Light Green { get; set; }
    public Light[] Lights { get; set; }
    public Input InputA { get; set; }
    public Input InputB { get; set; }
    public Input InputC { get; set; }
    public Input InputD { get; set; }
    public Input[] Inputs { get; set; }
    public Output OutputA { get; set; }
    public Output OutputB { get; set; }
    public Output OutputC { get; set; }
    public Output OutputD { get; set; }
    public Output[] Outputs { get; set; }
    public Button Button { get; set; }
    public Buzzer Buzzer { get; set; }
}