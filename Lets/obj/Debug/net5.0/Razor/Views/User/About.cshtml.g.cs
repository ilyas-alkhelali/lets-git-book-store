#pragma checksum "C:\Users\denis\source\repos\Lets\Lets\Views\User\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab420a15516c18416083464899b86de72082c44a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_About), @"mvc.1.0.view", @"/Views/User/About.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\denis\source\repos\Lets\Lets\Views\_ViewImports.cshtml"
using Lets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\denis\source\repos\Lets\Lets\Views\_ViewImports.cshtml"
using Lets.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab420a15516c18416083464899b86de72082c44a", @"/Views/User/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08c39280dd75dadb568c6cbbc0260051b15b4490", @"/Views/_ViewImports.cshtml")]
    public class Views_User_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lets.Models.Book>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Книга: ");
#nullable restore
#line 3 "C:\Users\denis\source\repos\Lets\Lets\Views\User\About.cshtml"
      Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab420a15516c18416083464899b86de72082c44a3238", async() => {
                WriteLiteral("\r\n<div>\r\n    <dl >\r\n        <dt>Автор</dt>\r\n        <dd>");
#nullable restore
#line 8 "C:\Users\denis\source\repos\Lets\Lets\Views\User\About.cshtml"
       Write(Model.Author);

#line default
#line hidden
#nullable disable
                WriteLiteral("</dd>\r\n\r\n        <dt>Страниц</dt>\r\n        <dd>");
#nullable restore
#line 11 "C:\Users\denis\source\repos\Lets\Lets\Views\User\About.cshtml"
       Write(Model.Pages);

#line default
#line hidden
#nullable disable
                WriteLiteral("</dd>\r\n\r\n        <dt>Картинка</dt>\r\n        <dd><img");
                BeginWriteAttribute("src", " src=\"", 243, "\"", 259, 1);
#nullable restore
#line 14 "C:\Users\denis\source\repos\Lets\Lets\Views\User\About.cshtml"
WriteAttributeValue("", 249, Model.img, 249, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 260, "\"", 278, 1);
#nullable restore
#line 14 "C:\Users\denis\source\repos\Lets\Lets\Views\User\About.cshtml"
WriteAttributeValue("", 266, Model.Title, 266, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></dd>\r\n        <dt>Дата выпуска\r\n        <dd>");
#nullable restore
#line 16 "C:\Users\denis\source\repos\Lets\Lets\Views\User\About.cshtml"
       Write(Model.Publication);

#line default
#line hidden
#nullable disable
                WriteLiteral("</dd>\r\n\r\n\r\n    </dl>\r\n</div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lets.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
