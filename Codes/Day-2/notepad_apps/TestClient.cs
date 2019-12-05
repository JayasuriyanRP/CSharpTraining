/*
method	 class		namespace	application
----------------------------------------------------
WriteLine Console	System		mscorlib.dll
SayHello  Messenger     TestLibrary	Test.dll
*/

using System;
using TestLibrary;

namespace  TestClient
{
	class Client
	{
		static void Main()
		{
			string message = 
			Messenger.SayHello("joydip");
			Console.WriteLine(message);
		}
	}
}