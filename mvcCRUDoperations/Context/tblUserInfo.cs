//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvcCRUDoperations.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tblUserInfo
    {
        public int empId { get; set; }
        [Required (ErrorMessage = "Redquired")]
        public string empName { get; set; }
        [Required(ErrorMessage = "Redquired")]
        [MinLength(10,ErrorMessage ="Mobile number should be 10")]
        public string empMobile { get; set; }
        [Required(ErrorMessage = "Redquired")]
        public string empAddress { get; set; }
        [Required(ErrorMessage = "Redquired")]
        public string empDept { get; set; }
    }
}