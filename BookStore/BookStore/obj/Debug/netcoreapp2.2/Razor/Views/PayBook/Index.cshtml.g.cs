#pragma checksum "E:\Devmaster\TaiLieu-DownLoad\BookStoreCSharp-master\BookStore\BookStore\Views\PayBook\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ace4442886903061276a51bcdbd47e5d7fb7874"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PayBook_Index), @"mvc.1.0.view", @"/Views/PayBook/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PayBook/Index.cshtml", typeof(AspNetCore.Views_PayBook_Index))]
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
#line 1 "E:\Devmaster\TaiLieu-DownLoad\BookStoreCSharp-master\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#line 2 "E:\Devmaster\TaiLieu-DownLoad\BookStoreCSharp-master\BookStore\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ace4442886903061276a51bcdbd47e5d7fb7874", @"/Views/PayBook/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7405129f38e4334088c9f99aab64f77db16eae6b", @"/Views/_ViewImports.cshtml")]
    public class Views_PayBook_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\Devmaster\TaiLieu-DownLoad\BookStoreCSharp-master\BookStore\BookStore\Views\PayBook\Index.cshtml"
  
    ViewData["Title"] = "Trá sách";

#line default
#line hidden
            BeginContext(41, 7891, true);
            WriteLiteral(@"
<div class=""wrapper wrapper-content animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox float-e-margins"">
                <div class=""ibox-title"">
                    <h5>Trả sách</h5>
                    <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
                        </a>
                        <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                            <i class=""fa fa-wrench""></i>
                        </a>
                        <ul class=""dropdown-menu dropdown-user"">
                            <li>
                                <a href=""#"">Config option 1</a>
                            </li>
                            <li>
                                <a href=""#"">Config option 2</a>
                            </li>
                        </ul>
                        <a class=""close-link"">
                         ");
            WriteLiteral(@"   <i class=""fa fa-times""></i>
                        </a>
                    </div>
                </div>
                <div class=""ibox-content"">
                    <div class=""row"">
                        <div class=""col-lg-4"">
                            <div class=""form-group"">
                                <label for=""customerId"">Mã khách *</label>
                                <input id=""customerId"" name=""customerId"" type=""text"" class=""form-control"" placeholder=""Mã khách"">
                            </div>
                        </div>
                        <div class=""col-lg-4"">
                            <div class=""form-group"">
                                <label for=""customerPhone"">Số điện thoại *</label>
                                <input id=""customerPhone"" name=""customerPhone"" type=""number"" class=""form-control @*required*@"" placeholder=""Số điện thoại"">
                            </div>
                        </div>
                        <div class=""col-lg-4"">
          ");
            WriteLiteral(@"                  <div class=""form-group"">
                                <label for=""customerName"">Họ tên</label>
                                <input id=""customerName"" name=""customerName"" type=""text"" class=""form-control"" placeholder=""Họ tên"" readonly> 
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-lg-4"">
                            <div class=""form-group"">
                                <label for=""rentId"">Mã thuê *</label>
                                <input id=""rentId"" name=""rentId"" type=""text"" class=""form-control"" placeholder=""Mã thuê"">
                            </div>
                        </div>
                        <div class=""col-lg-4"">
                            <div class=""form-group"">
                                <label for=""customerPhone"">Mã sách</label>
                                <input id=""bookId"" name=""bookId"" type=""number"" class=""form-control @*re");
            WriteLiteral(@"quired*@"" placeholder=""Mã sách"" readonly>
                            </div>
                        </div>
                        <div class=""col-lg-4"">
                            <div class=""form-group"">
                                <label for=""bookName"">Tên sách</label>
                                <input id=""bookName"" name=""bookName"" type=""text"" class=""form-control"" placeholder=""Tên sách"" readonly>
                            </div>
                        </div>
                    </div>
                    <p class=""font-italic"">( Nhập số điện thoại và nhấn Enter để tìm kiếm khách hàng )</p>
                    <div class=""row"">
                        <div class=""col-lg-4"">
                            <button class=""btn btn-primary"" id=""search-rent""><i class=""fa fa-search"" aria-hidden=""true""></i> Tìm kiếm</button>
                        </div>
                    </div>
                    <br />
                    <div class=""ibox-content"">
                        <div class=""row"">
        ");
            WriteLiteral(@"                    <div class=""col-lg-6 b-r"">
                                <ul class=""sortable-list connectList agile-list ui-sortable hidden"">
                                    <li class=""info-element ui-sortable-handle"">
                                        <h3>Danh sách thuê</h3>
                                    </li>
                                </ul>
                                <ul class=""sortable-list connectList agile-list ui-sortable"" id=""rent-list"">
                                </ul>
                            </div>
                            <div class=""col-lg-6"">
                                <ul class=""sortable-list connectList agile-list ui-sortable hidden"">
                                    <li class=""info-element ui-sortable-handle"">
                                        <h3>Chi tiết trả sách</h3>
                                    </li>
                                    <div id=""collapseOne"" class=""panel-collapse collapse in"" aria-expanded=""true"">
            ");
            WriteLiteral(@"                            <div class=""panel-body"">
                                            <table class=""table table-hover table-striped table-bordered"" id=""pay-detail-table"">
                                                <thead>
                                                    <tr>
                                                        <th width=""10%"">Mã thuê</th>
                                                        <th width=""10%"">Mã sách</th>
                                                        <th width=""25%"">Tên sách</th>
                                                        <th width=""20%"">Vi phạm</th>
                                                        <th width=""15%"">Thành tiền</th>
                                                        <th width=""10%"" style=""text-align: center"">Hủy trả</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                 ");
            WriteLiteral(@"                               </tbody>
                                            </table>
                                            <dl class=""dl-horizontal pull-right"" style=""margin-bottom: 0px"">
                                                <dt>Tiền thuê:</dt>
                                                <dd><span class=""font-bold"" id=""totalRentMoney"">0</span></dd>
                                            </dl>
                                            <div class=""clearfix""></div>
                                            <dl class=""dl-horizontal pull-right"" style=""margin-bottom: 0px"">
                                                <dt>Tiền cọc:</dt>
                                                <dd><span class=""font-bold"" id=""totalDeposit"">0</span></dd>
                                            </dl>
                                            <div class=""clearfix""></div>
                                            <dl class=""dl-horizontal pull-right"" style=""margin-bottom: 0px"">
     ");
            WriteLiteral(@"                                           <dt>Tổng tiền:</dt>
                                                <dd><span class=""bg-danger font-bold"" id=""totalMoney"">0</span></dd>
                                            </dl>
                                            <div class=""clearfix""></div>
                                            <button class=""btn btn-primary pull-right"" id=""confirm-pay"">Xác nhận</button>
                                        </div>
                                    </div>
                                </ul>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>

    </div>
</div>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(7950, 52, true);
                WriteLiteral("\n    <script src=\"/javascript/paybook.js\"></script>\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
