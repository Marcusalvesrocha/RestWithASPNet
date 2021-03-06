using System;
namespace RestWithASPNet.Configurations
{
    public class TokenConfiguration
    {
        public TokenConfiguration()
        {
        }

        public string Audience { get; set; }

        public string Issuer { get; set; }

        public string Secret { get; set; }

        public int Minutes { get; set; }

        public int DaysToExpiry { get; set; }
    }
}
