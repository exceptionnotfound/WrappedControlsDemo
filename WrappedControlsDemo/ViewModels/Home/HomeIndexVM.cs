using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WrappedControlsDemo.ViewModels.Home
{
    public class HomeIndexVM
    {
        [Display(Name = "Regular text:")]
        public string RegularText { get; set; }
        [Display(Name = "Wrapped text:")]
        public string WrappedText { get; set; }
    }
}