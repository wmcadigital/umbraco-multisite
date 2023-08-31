using System;
using System.Linq;
using Limbo.Umbraco.BlockList.Converters;
using Limbo.Umbraco.BlockList.PropertyEditors;
using Umbraco.Cms.Core.Models.Blocks;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace Wmca.Core.BlockList
{
    public class BlockListTypeConverter : IBlockListTypeConverter
    {

        public string Name => "Block Item Converter";

        public Type GetType(IPublishedPropertyType propertyType, LimboBlockListConfiguration config)
        {
            return config.IsSinglePicker ? typeof(BlockItem) : typeof(IReadOnlyList<BlockItem>);
        }

        public object? Convert(IPublishedElement owner, IPublishedPropertyType propertyType, BlockListModel? source, LimboBlockListConfiguration config)
        {

            if (source == null) return config.IsSinglePicker ? null : Array.Empty<BlockItem>();

            if (!config.IsSinglePicker) return source.Select(x => new BlockItem(x)).ToArray();

            BlockListItem? first = source.FirstOrDefault();
            return first == null ? null : new BlockItem(first);

        }

    }
}

