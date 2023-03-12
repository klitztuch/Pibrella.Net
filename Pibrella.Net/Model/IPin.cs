using System.Device.Gpio;

namespace Pibrella.Net.Model;

public interface IPin
{
    public int Pin { get; }

    PinValue Read()
    {
        using var controller = new GpioController();
        controller.OpenPin(Pin, PinMode.Output);
        return controller.Read(Pin);
    }

    bool IsOn()
    {
        return Read() == true;
    }

    bool IsOff()
    {
        return Read() == false;
    }
}