using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raggle.Search.Core;

public interface IKnowledgeRepository
{
    public List<Knowledge> Search(string query, KnowledgeRepositoryConfig? config = null);
}
