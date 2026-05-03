using Microsoft.Extensions.Options;

namespace OptionsPattern
{
    public class Service
    {
        private readonly MySettings _settings;
       
        public Service(IOptions<MySettings> options)
        {
            _settings = options.Value;
        }

        public void Print()
        {
            Console.WriteLine(_settings.AppName);
            Console.WriteLine(_settings.MaxUsers);
        }
    }
}
