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
    
    public partial class roomprice_t
    {
        public int id { get; set; }
        public string hotelcode { get; set; }
        public string roomtypecode { get; set; }
        public string ratecode { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<System.DateTime> starttime { get; set; }
        public Nullable<System.DateTime> endtime { get; set; }
        public Nullable<int> num { get; set; }
        public Nullable<System.DateTime> addtime { get; set; }
        public string C_level__INTEGER_DEFAULT_0________package { get; set; }
        public Nullable<int> flag { get; set; }
    }
}
