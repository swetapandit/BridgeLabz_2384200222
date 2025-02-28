using System;
using RepositoryLayer;

namespace BusinessLayer.Services
{
	public class RegisterHelloBL
	{
        RegisterHelloRL _registerHelloRL;
		public RegisterHelloBL(RegisterHelloRL registerHelloRL)
		{
			_registerHelloRL = registerHelloRL;
		}

		public string registration(string name)
		{
			return "Data from Bussiness Layer" + _registerHelloRL.GetHello(name);
		}
	}
}

