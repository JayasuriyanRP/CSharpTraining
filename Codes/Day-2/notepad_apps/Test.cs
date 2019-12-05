using System;

namespace  TestLibrary
{
	public class Messenger
	{
		public static string SayHello(
					string name)
		{
			string message 
				= $"hello {name}";
			return message;
		}
	}
}