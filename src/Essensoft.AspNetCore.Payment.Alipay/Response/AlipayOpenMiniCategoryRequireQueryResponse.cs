using System.Text.Json.Serialization;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniCategoryRequireQueryResponse.
    /// </summary>
    public class AlipayOpenMiniCategoryRequireQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 类目对应资质列表
        /// </summary>
        [JsonPropertyName("category_require_info_list")]
        public List<CategoryRequireInfo> CategoryRequireInfoList { get; set; }
    }
}
