/*using System;

class Device
{
    private int deviceId;
    private string status;

    public Device(int deviceId, string status)
    {
        this.deviceId = deviceId;
        this.status = status;
    }

    public int GetDeviceId()
    {
        return deviceId;
    }

    public string GetDeviceStatus()
    {
        return status;
    }
}

class Thermostat : Device
{
    private string tempSetting;

    public Thermostat(int deviceId, string status, string tempSetting) : base(deviceId, status)
    {
        this.tempSetting = tempSetting;
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"Device Id: {GetDeviceId()}");
        Console.WriteLine($"Device Status: {GetDeviceStatus()}");
        Console.WriteLine($"Temperature Setting: {tempSetting}");
    }
}

class Program
{
    public static void Main()
    {
        Thermostat thermostat = new Thermostat(1, "On", "23");
        thermostat.DisplayStatus();
        Console.ReadLine();
    }
}*/