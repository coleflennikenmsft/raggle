using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raggle.Search.Core;

public class Knowledge : IKnowledge
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string Format() => $"<knowledge><title>{Title}</title><content>{Content}</content></knowledge>";

}
