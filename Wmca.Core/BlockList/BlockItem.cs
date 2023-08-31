using Umbraco.Cms.Core.Models.Blocks;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Wmca.Core.BlockList
{
    public class BlockItem
    {

        public Guid ContentKey { get; }

        public string Type { get; }

        public IPublishedElement Content { get; }

        public BlockItem(BlockListItem blockListItem)
        {
            ContentKey = blockListItem.Content.Key;
            Type = blockListItem.Content.ContentType.Alias;
            Content = blockListItem.Content;
        }

    }
}

