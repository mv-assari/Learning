using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelper.Models
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    //[HtmlTargetElement("tag-name")]//اگر میخواهیم نام خاصی به تگ دهیم از این خاصیت استفاده میکنم در غیر این صورت پیش فرض نام کلاس نام تگ هست
    public class EmailTagHelper : TagHelper
    {
        private string domain = "mva.net";
        public string MailTo {  get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            string address = MailTo + "@" + domain;
            output.Attributes.SetAttribute("href","mailto:"+address);
            output.Content.SetContent(address);
        }
    }
}
