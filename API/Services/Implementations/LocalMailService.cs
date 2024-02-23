using Microsoft.Extensions.Configuration;
using System;
using System.Diagnostics;

namespace API.Services.Implementations
{
    public class LocalMailService : ILocalMailService
    {
        private string _emailTo { get; set; }
        private string _emailFrom { get; set; }

        private IConfiguration _configuration;

        public LocalMailService(IConfiguration configuration) 
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _emailTo = _configuration["MailSettings:mailToAddress"];
            _emailFrom = _configuration["MailSettings:mailFromAddress"];
        }

        public void Send(string subject, string message)
        {
            Debug.WriteLine($"Meil have been sending from {_emailFrom} to {_emailTo}");
            Debug.WriteLine($"Subject {subject}");
            Debug.WriteLine($"Message {message}");
        }
    }
}
