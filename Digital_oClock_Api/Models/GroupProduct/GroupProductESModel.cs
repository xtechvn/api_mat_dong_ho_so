using Nest;
using System.Runtime.InteropServices;

namespace HuloToys_Service.Models.ElasticSearch
{
    public partial class GroupProductModel
    {
        [PropertyName("id")]
        public int id { get; set; }
        [PropertyName("ParentId")]
        public int parentid { get; set; }
        [PropertyName("PositionId")]
        public int? positionid { get; set; }
        [PropertyName("Name")]
        public string name { get; set; } = null!;
        [PropertyName("ImagePath")]
        public string? imagepath { get; set; }
        [PropertyName("OrderNo")]
        public int? orderno { get; set; }
        [PropertyName("Path")]
        public string? path { get; set; }
        [PropertyName("Status")]
        public int? status { get; set; }
        [PropertyName("CreatedOn")]
        public DateTime? createdon { get; set; }
        [PropertyName("ModifiedOn")]
        public DateTime? modifiedon { get; set; }
        [PropertyName("Description")]
        public string? description { get; set; }
        [PropertyName("IsShowHeader")]
        public bool isshowheader { get; set; }
        [PropertyName("IsShowFooter")]
        public bool isshowfooter { get; set; }

        public List<GroupProductModel> group_product_child { get; set; }
    }
}
