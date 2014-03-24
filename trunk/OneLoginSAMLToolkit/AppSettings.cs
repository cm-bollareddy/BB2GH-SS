using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace OneLoginSAMLToolkit
{
    public class AppSettings
    {
        public string assertionConsumerServiceUrl = ConfigurationSettings.AppSettings["assertionConsumerServiceUrl"];
        public string issuer = ConfigurationSettings.AppSettings["issuer"];
    }
}
