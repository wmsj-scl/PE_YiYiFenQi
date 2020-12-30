﻿using System.Collections.Generic;

namespace Protocol.CommonData
{
    [System.Serializable]
    public class BorrowInformatio
    {
        /// <summary>
        /// 账号
        /// </summary>
        public string account;

        /// <summary>
        /// 总借款金额
        /// </summary>
        public float allMoney;

        /// <summary>
        /// 利率
        /// </summary>
        public float rateInterest;

        /// <summary>
        /// 分期期数
        /// </summary>
        public int stagesNumber;

        /// <summary>
        /// 借款日期
        /// </summary>
        public long dateTime;

        /// <summary>
        /// 还款记录
        /// </summary>
        public List<PaymentInfo> paymentInfos = new List<PaymentInfo>(); 
    }

    [System.Serializable]
    public struct PaymentInfo
    {
        /// <summary>
        /// 还款日期
        /// </summary>
        public long dateTime;

        /// <summary>
        /// 还款金额
        /// </summary>
        public float allMoney;

        /// <summary>
        /// 利息
        /// </summary>
        public float interestMoney;

        /// <summary>
        /// 本金
        /// </summary>
        public float principal;
    }
}
