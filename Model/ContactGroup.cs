//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Model
{
    public partial class ContactGroup
    {
        public long Id { get; set; }
        public long ContactId { get; set; }
        public string Name { get; set; }
    
        public virtual Contact Contact { get; set; }
    }
    
}
