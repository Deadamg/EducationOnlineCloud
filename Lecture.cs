//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineEducation
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lecture
    {
        public int Lecture_ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public Nullable<int> Type_ID { get; set; }
        public string Image_One { get; set; }
        public string Image_Two { get; set; }
        public string Image_Three { get; set; }
        public string Image_Four { get; set; }
        public string Image_Five { get; set; }
        public string Image_Six { get; set; }
        public string Description { get; set; }
        public string Video { get; set; }
    
        public virtual LectureType LectureType { get; set; }
    }
}
