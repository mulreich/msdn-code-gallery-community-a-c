//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Api_Authorization.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserAuthentication
    {
        public int AuthenticationID { get; set; }
        public int UserID { get; set; }
        public Nullable<int> RoleID { get; set; }
        public string LoginID { get; set; }
        public string UserName { get; set; }
        public string LoginEmail { get; set; }
        public string LoginPhone { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public Nullable<int> StatusID { get; set; }
    
        public virtual UserRole UserRole { get; set; }
    }
}
