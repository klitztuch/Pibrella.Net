using Pibrella.Net.Model;

namespace Pibrella.Net;

public interface IPibrella
{
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