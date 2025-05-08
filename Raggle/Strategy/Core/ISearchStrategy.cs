using Raggle.Search.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raggle.Strategy.Core;

public interface ISearchStrategy
{
    public List<Knowledge> Execute(string query, List<IKnowledgeRepository> knowledgeRepositories);
}
