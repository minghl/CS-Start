using System;
using LogServices;

namespace Microsoft.Extensions.DependencyInjection
{
	public static class ConsoleLogExtentions
	{
		public static void AddConsoleLog( this IServiceCollection services)
		{
			services.AddScoped<ILogProvider, ConsoleLogProvider>();
		}
	}
}

