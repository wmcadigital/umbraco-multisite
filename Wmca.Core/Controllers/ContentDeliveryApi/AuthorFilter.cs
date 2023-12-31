﻿using Umbraco.Cms.Core;
using Umbraco.Cms.Core.DeliveryApi;
using Umbraco.Cms.Core.Models;

namespace Wmca.Core.Controllers.ContentDeliveryApi
{
    public class AuthorFilter : IFilterHandler, IContentIndexHandler
    {
        private const string AuthorSpecifier = "author:";
        private const string FieldName = "authorId";

        // Querying
        public bool CanHandle(string query)
            => query.StartsWith(AuthorSpecifier, StringComparison.OrdinalIgnoreCase);

        public FilterOption BuildFilterOption(string filter)
        {
            var fieldValue = filter.Substring(AuthorSpecifier.Length);

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
            GuidUdi? authorUdi = content.GetValue<GuidUdi>("author");

            if (authorUdi is null)
            {
                return Array.Empty<IndexFieldValue>();
            }

            return new[]
            {
                new IndexFieldValue
                {
                    FieldName = FieldName,
                    Values = new object[] { authorUdi.Guid }
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
