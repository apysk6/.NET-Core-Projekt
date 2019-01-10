using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarProjectWebsite.TagHelpers
{
    [HtmlTargetElement("*", Attributes = "asp-if")]
    public class IfTagHelper : TagHelper
    {
        [HtmlAttributeName("asp-if")]
        public bool Predicate { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!Predicate)
            {
                output.SuppressOutput();
            }
        }
    }
}
