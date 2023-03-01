using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_bbdaley.Infrastructure
{
    [HtmlTargetElement("div", Attributes = " page-blah")]
    public class PaginationTagHelper : TagHelper
    {
        // dynamically create the page links
    }
}
