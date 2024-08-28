using Umbraco.Cms.Core;
using Umbraco.Cms.Core.DeliveryApi;
using Umbraco.Cms.Core.Models;

namespace Wmca.Core.Controllers.ContentDeliveryApi
{
    public class CategoryFilter : IFilterHandler, IContentIndexHandler
    {
        private const string TagSpecifier = "tags:";
        private const string FieldName = "tagId";

        // Querying
        public bool CanHandle(string query)
            => query.StartsWith(TagSpecifier, StringComparison.OrdinalIgnoreCase);

        public FilterOption BuildFilterOption(string filter)
        {
            var fieldValue = filter.Substring(TagSpecifier.Length);

            // There might be several values for the filter
            var values = fieldValue.Split(',');

            return new FilterOption
            {
                FieldName = FieldName,
                Values = values,
                Operator = FilterOperation.Is
            };
        }

        // Indexing
        public IEnumerable<IndexFieldValue> GetFieldValues(IContent content, string? culture)
        {
            GuidUdi? tagUdi = content.GetValue<GuidUdi>("tags");

            if (tagUdi is null)
            {
                return Array.Empty<IndexFieldValue>();
            }

            return new[]
            {
                new IndexFieldValue
                {
                    FieldName = FieldName,
                    Values = new object[] { tagUdi.Guid }
                }
            };
        }

        public IEnumerable<IndexField> GetFields() => new[]
        {
            new IndexField
            {
                FieldName = FieldName,
                FieldType = FieldType.StringRaw,
                VariesByCulture = false
            }
        };
    }
}
