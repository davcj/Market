using System;
using System.Collections.Generic;

namespace TestLibrary.Entities
{
    public partial class SocialMedia
    {
        public int IdSocialMedia { get; set; }
        public int IdSocialMediaType { get; set; }
        public int IdTradingObject { get; set; }
        public string AccountId { get; set; }
        public string UserName { get; set; }

        public virtual SocialMediaType IdSocialMediaTypeNavigation { get; set; }
        public virtual TradingObject IdTradingObjectNavigation { get; set; }
    }
}
