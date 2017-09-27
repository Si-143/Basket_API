using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ClientLibrary
{
	class Program
	{

		static void Main()
		{
			RunAsync().Wait();
		}

		static async Task RunAsync()
		{
			Console.ReadLine();
		}

		static async Task RunAsync()
		{
			// New code:
			client.BaseAddress = new Uri("localhost:5000/api/");
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

			Console.ReadLine();
		}
	}
}