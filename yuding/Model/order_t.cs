//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace yuding.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class order_t
    {
        public order_t()
        {
            this.flag = 0;
            this.state = "R";
            this.ispay = 0;
            this.isdeal = 0;
            this.type = 0;
        }
    
        public int id { get; set; }
        public string guestname { get; set; }
        public string bosscard { get; set; }
        public string hotelcode { get; set; }
        public string hotelname { get; set; }
        public string ptchannel { get; set; }
        public string channelid { get; set; }
        public string sourceid { get; set; }
        public string marketid { get; set; }
        public string roomtype { get; set; }
        public string ratecode { get; set; }
        public System.DateTime arrivetime { get; set; }
        public System.DateTime leavetime { get; set; }
        public Nullable<int> adult { get; set; }
        public Nullable<int> child { get; set; }
        public string mobile { get; set; }
        public string notes { get; set; }
        public Nullable<System.DateTime> addtime { get; set; }
        public Nullable<int> flag { get; set; }
        public Nullable<int> count { get; set; }
        public Nullable<decimal> rate { get; set; }
        public string roomname { get; set; }
        public string crsorder { get; set; }
        public string state { get; set; }
        public string fromcompany { get; set; }
        public Nullable<int> ispay { get; set; }
        public string sessionid { get; set; }
        public string ordernumber { get; set; }
        public Nullable<int> isid { get; set; }
        public string resby { get; set; }
        public string contact_name { get; set; }
        public string contact_mobile { get; set; }
        public string trueRate { get; set; }
        public Nullable<int> isdeal { get; set; }
        public string pay { get; set; }
        public string xz_code { get; set; }
        public string xz_name { get; set; }
        public string yuanjia { get; set; }
        public string baojia { get; set; }
        public string wxcode { get; set; }
        public Nullable<int> type { get; set; }
        public Nullable<decimal> increasemoney { get; set; }
        public string formulaid { get; set; }
        public string categoryid { get; set; }
        public Nullable<decimal> yhmoney { get; set; }
        public string tpid { get; set; }
        public string lvorder { get; set; }
        public string City { get; set; }
        public string isSendMsg { get; set; }
        public string TicketSn { get; set; }
        public Nullable<decimal> Fmoney { get; set; }
    }
}
