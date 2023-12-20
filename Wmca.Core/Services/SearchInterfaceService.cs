using System.Collections.Generic;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Wmca.Core.Services
{
	public interface ISearchService
    {
        IEnumerable<IPublishedContent> SearchContentNames(string query);
    }
}