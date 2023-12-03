using ConfigServices;
using LogServices;
using MailServices;
using Microsoft.Extensions.DependencyInjection;
namespace MailSender;

class Program
{
    static void Main(string[] args)
    {
        ServiceCollection services = new ServiceCollection();
        services.AddScoped<IConfigService, EnvVarConfigService>();
        services.AddScoped<IMailService, MailService>();
        services.AddScoped<ILogProvider, ConsoleLogProvider>();

        using (var sp = services.BuildServiceProvider())
        {
            // 第一个跟对象只能用ServiceLocator
            var mailService = sp.GetRequiredService<IMailService>();
            mailService.Send("Hello", "trump@usa.gov", "懂王你好");
        }
        Console.Read();
    }
}

