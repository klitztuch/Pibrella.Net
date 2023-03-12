using System.Device.Gpio;

namespace Pibrella.Net.Model;

public interface IOutput : IPin
{
    void On()
    {
        using var controller = new GpioController();
        controller.OpenPin(Pin, PinMode.Output);
        controller.Write(Pin, 1);
    }

    void Off()
    {
        using var controller = new GpioController();
        controller.OpenPin(Pin, PinMode.Output);
        controller.Write(Pin, 0);
    }
}