﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransCommonQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundTransCommonQueryModel : AlipayObject
    {
        /// <summary>
        /// 描述特定的业务场景，如果传递了out_biz_no则该字段为必传。可取的业务场景如下：  PERSONAL_PAY：C2C现金红包-发红包；  PERSONAL_COLLECTION：C2C现金红包-领红包；  REFUND：C2C现金红包-红包退回；  DIRECT_TRANSFER：B2C现金红包、单笔无密转账
        /// </summary>
        [JsonProperty("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 支付宝转账单据号：  本参数和商户转账唯一订单号、支付宝支付资金流水号三者不能同时为空。  当本参数和商户转账唯一订单号、支付宝支付资金流水号三者同时提供时，将用支付宝支付资金流水号进行查询，忽略其余两者；  当本参数和支付宝支付资金流水号同时提供时，将用支付宝支付资金流水号进行查询，忽略本参数。  当本参数和商户转账唯一订单号同时提供时，将用本参数进行查询，忽略商户转账唯一订单号。
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户转账唯一订单号：发起转账来源方定义的转账单据ID。  本参数和支付宝转账单据号、支付宝支付资金流水号三者不能同时为空。  当本参数和支付宝转账单据号、支付宝支付资金流水号同时提供时，将用支付宝支付资金流水号进行查询，忽略本参数；  当本参数和支付宝转账单据号同时提供时，将用支付宝转账单据号进行查询，忽略本参数；
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 支付宝支付资金流水号：  本参数和支付宝转账单据号、商户转账唯一订单号三者不能同时为空。  当本参数和支付宝转账单据号、商户转账唯一订单号同时提供时，将用本参数进行查询，忽略本参数；  当本参数和支付宝转账单据号同时提供时，将用本参数进行查询，忽略支付宝转账单据号；  当本参数和商户转账唯一订单号同时提供时，将用本参数进行查询，忽略商户转账唯一订单号；
        /// </summary>
        [JsonProperty("pay_fund_order_id")]
        public string PayFundOrderId { get; set; }

        /// <summary>
        /// 销售产品码，商家和支付宝签约的产品码，如果传递了out_biz_no则该字段为必传。可传值如下：  STD_RED_PACKET：现金红包  TRANS_ACCOUNT_NO_PWD：单笔无密转账
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }
    }
}