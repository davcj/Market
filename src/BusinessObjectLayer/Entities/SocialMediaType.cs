using System;
using System.Collections.Generic;

namespace BusinessObjectLayer.Entities
{
    public partial class SocialMediaType
    {
        public SocialMediaType()
        {
            SocialMedia = new HashSet<SocialMedia>();
        }

        public int IdSocialMediaType { get; set; }
        public string Name { get; set; }
        public string Attr1 { get; set; }
        public string Attr2 { get; set; }
        public string Attr3 { get; set; }

        public virtual ICollection<SocialMedia> SocialMedia { get; set; }
    }
}
