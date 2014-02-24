using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SteamBot
{
    class ScrapUserHandlerConfiguration : UserHandlerConfigurationBase<ScrapUserHandlerConfiguration>
    {
        public int AllowedInvalidItemAttempts { get; set; }
        public string TradeGreetMessage { get; set; }
        public string TradeGreetMessage2 { get; set; }
    }
}
