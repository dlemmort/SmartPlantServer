using System.Net;
using System.Text;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace SmartPlantServer.Mqtt;

public class PlantMqttClient : MqttClient
{
    public PlantMqttClient(IPAddress address) : base(address)
    {
        Subscribe(new string[] { "home/plant" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
        MqttMsgPublishReceived += messageHandler;
    }

    static void messageHandler(object sender, MqttMsgPublishEventArgs e)
    {
        Console.WriteLine("Received = " + Encoding.UTF8.GetString(e.Message) + " on topic " + e.Topic);
    }

    public void publishMessage(String msg)
    {
        Publish("home/plant", Encoding.UTF8.GetBytes(msg), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, true);
    }
}