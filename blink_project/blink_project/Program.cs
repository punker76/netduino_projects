using System.Threading;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace blink_project
{
  public class Program
  {
    public static void Main() {
      // write your code here
      var led = new OutputPort(Pins.ONBOARD_LED, false);

      while (true) {
        led.Write(true); // turn on the led
        Thread.Sleep(250); // sleep for 250 ms
        led.Write(false); // turn off the led
        Thread.Sleep(250); // sleep for 250 ms
      }
    }
  }
}