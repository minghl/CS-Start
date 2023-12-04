using ConfigServices;
//using LogServices;
using MailServices;
using Microsoft.Extensions.DependencyInjection;
namespace MailSender;

class Program
{
    static void Main(string[] args)
    {
        ServiceCollection services = new ServiceCollection();
        //services.AddScoped(typeof(IConfigService),s=>new IniFileConfigService { FilePath="mail.ini"});
        services.AddIniFileConfig("mail.ini");
        services.AddScoped<IMailService, MailService>();
        //services.AddScoped<ILogProvider, ConsoleLogProvider>();
        services.AddConsoleLog(); //提供一个AddXX方法；能够自动提示出来
        using (var sp = services.BuildServiceProvider())
        {
            // 第一个跟对象只能用ServiceLocator
            var mailService = sp.GetRequiredService<IMailService>();
            mailService.Send("Hello", "trump@usa.gov", "懂王你好");
        }
        Console.Read();
    }
}

