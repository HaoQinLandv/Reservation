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
    
    public partial class GetRoomAndPrice
    {
        public int id { get; set; }
        public string hotelid { get; set; }
        public string xz_code { get; set; }
        public Nullable<System.DateTime> everydate { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<System.DateTime> addtime { get; set; }
        public string addname { get; set; }
        public Nullable<int> num { get; set; }
        public Nullable<int> ordernum { get; set; }
        public Nullable<int> package { get; set; }
        public Nullable<int> islock { get; set; }
        public Nullable<int> avail { get; set; }
        public Nullable<int> WeekIndex { get; set; }
        public string roomtype { get; set; }
    }
}
