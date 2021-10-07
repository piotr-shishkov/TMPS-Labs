# Creational Design Patterns


## Author: Piotr Shishkov (FAF-193)

----

## Objectives:

* Get familiar with the Creational DPs;
* Choose a specific domain;
* Implement at least 3 CDPs for the specific domain;


## Used Design Patterns: 

* Singleton
* Builder
* Abstract Factory


## Implementation
**Singleton Pattern implementation**
<br>
Used to access *instance* of class

```c#
private static DeviceStand instance;

public static DeviceStand GetInstance()
{
	if (instance == null)
	{
		instance = new DeviceStand();
	}
	return instance;
}
```

**Builder Pattern implementation**
<br>
Used to setup object of *Device* class and build them

```c#
protected Device device;

public DeviceBuilder()
{
	device = new Device(0);
}

public DeviceBuilder SetSerialNumber(string serialNumber)
{
	device.SerialNumber = serialNumber;
	return this;
}

public DeviceBuilder SetManufacturer(string manufacturer)
{
	device.Manufacturer = manufacturer;
	return this;
}

public DeviceBuilder SetModel(string model)
{
    device.Model = model;
	return this;
}

public Device CreateDevice()
{
	return device;
}
```

**Abstract Factory Pattern implementation**
<br>
DeviceFactory and derived factories which implement *Abstract Factory* pattern

```c#
public abstract class DeviceFactory
{
	public abstract DeviceBuilder GetDeviceBuilder();
}

public class PhoneFactory : DeviceFactory
{
	public override DeviceBuilder GetDeviceBuilder()
	{
		return new PhoneBuilder();
	}
}

public class LaptopFactory : DeviceFactory
{
	public override DeviceBuilder GetDeviceBuilder()
	{
		return new LaptopBuilder();
	}
}
```

## Conclusions / Screenshots / Results
Result of execution

![Result](https://i.imgur.com/48hQQU3.png)