using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.ComputedFields;
using Sitecore.Data;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;

namespace SitecoreMediaTagging.Computed
{
    public class TagsFacet : IComputedIndexField
    {
        //sitecore/templates/System/Templates/Sections/Tagging/Tagging/__Semantics
        private static readonly ID Semantics = new ID("{A14F1B0C-4384-49EC-8790-28A440F3670C}");
        public string FieldName { get; set; }
        public string ReturnType { get; set; }
        public object ComputeFieldValue(IIndexable indexable)
        {
            var indexableItem = indexable as SitecoreIndexableItem;
            //sitecore/templates/System/Media/Unversioned/Jpeg
            if (indexableItem.Item.TemplateID.ToString().Trim() == "{DAF085E8-602E-43A6-8299-038FF171349F}")
            {
                return indexableItem == null ? null : indexableItem.Item.GetMultiListValues(Semantics).Select(tag => tag.DisplayName).ToList();
        }
            else
            {
                return null;
            }
        }
    }

    public static class HelperMethods
    {
        public static IEnumerable<Item> GetMultiListValues(this Item item, ID fieldId)
        {
            return (new MultilistField(item.Fields[fieldId])).GetItems();
        }
    }
}