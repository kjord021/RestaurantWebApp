#pragma checksum "C:\Users\Kyle\source\repos\kjord021\RestaurantWebApp\AwesomeRestaurant\Pages\Restaurants\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a04c701b68200b21aee6075d39fa1eee8045c82e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AwesomeResturant.Pages.Restaurants.Pages_Restaurants_Detail), @"mvc.1.0.razor-page", @"/Pages/Restaurants/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Restaurants/Detail.cshtml", typeof(AwesomeResturant.Pages.Restaurants.Pages_Restaurants_Detail), @"{restaurantID:int}")]
namespace AwesomeResturant.Pages.Restaurants
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Kyle\source\repos\kjord021\RestaurantWebApp\AwesomeRestaurant\Pages\_ViewImports.cshtml"
using AwesomeResturant;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{restaurantID:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a04c701b68200b21aee6075d39fa1eee8045c82e", @"/Pages/Restaurants/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a45f3b05c9d649e4dbcffe2c2e17fe2fc618337", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restaurants_Detail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./List", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(90, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(97, 21, false);
#line 6 "C:\Users\Kyle\source\repos\kjord021\RestaurantWebApp\AwesomeRestaurant\Pages\Restaurants\Detail.cshtml"
Write(Model.Restaurant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(118, 22, true);
            WriteLiteral("</h2>\r\n<div>\r\n    ID: ");
            EndContext();
            BeginContext(141, 19, false);
#line 8 "C:\Users\Kyle\source\repos\kjord021\RestaurantWebApp\AwesomeRestaurant\Pages\Restaurants\Detail.cshtml"
   Write(Model.Restaurant.ID);

#line default
#line hidden
            EndContext();
            BeginContext(160, 31, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Location: ");
            EndContext();
            BeginContext(192, 25, false);
#line 11 "C:\Users\Kyle\source\repos\kjord021\RestaurantWebApp\AwesomeRestaurant\Pages\Restaurants\Detail.cshtml"
         Write(Model.Restaurant.Location);

#line default
#line hidden
            EndContext();
            BeginContext(217, 30, true);
            WriteLiteral("\r\n</div>\r\n<div>\r\n    Cuisine: ");
            EndContext();
            BeginContext(248, 24, false);
#line 14 "C:\Users\Kyle\source\repos\kjord021\RestaurantWebApp\AwesomeRestaurant\Pages\Restaurants\Detail.cshtml"
        Write(Model.Restaurant.Cuisine);

#line default
#line hidden
            EndContext();
            BeginContext(272, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
#line 17 "C:\Users\Kyle\source\repos\kjord021\RestaurantWebApp\AwesomeRestaurant\Pages\Restaurants\Detail.cshtml"
 if (Model.Message != null) 
{

#line default
#line hidden
            BeginContext(317, 34, true);
            WriteLiteral("    <div class=\"alert alert-info\">");
            EndContext();
            BeginContext(352, 13, false);
#line 19 "C:\Users\Kyle\source\repos\kjord021\RestaurantWebApp\AwesomeRestaurant\Pages\Restaurants\Detail.cshtml"
                             Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(365, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 20 "C:\Users\Kyle\source\repos\kjord021\RestaurantWebApp\AwesomeRestaurant\Pages\Restaurants\Detail.cshtml"
}

#line default
#line hidden
            BeginContext(376, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(378, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "277db9c863764deb938b449000a523dc", async() => {
                BeginContext(423, 15, true);
                WriteLiteral("All Restaurants");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AwesomeResturant.Pages.Restaurants.DetailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AwesomeResturant.Pages.Restaurants.DetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AwesomeResturant.Pages.Restaurants.DetailModel>)PageContext?.ViewData;
        public AwesomeResturant.Pages.Restaurants.DetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
