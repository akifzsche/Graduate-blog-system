// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace mvvm1.Shared
{
    #line hidden
#nullable restore
#line 2 "C:\Users\Akif\Desktop\mvvm1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Akif\Desktop\mvvm1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Akif\Desktop\mvvm1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Akif\Desktop\mvvm1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Akif\Desktop\mvvm1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Akif\Desktop\mvvm1\_Imports.razor"
using mvvm1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Akif\Desktop\mvvm1\_Imports.razor"
using mvvm1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Akif\Desktop\mvvm1\Shared\NavMenu.razor"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Akif\Desktop\mvvm1\Shared\NavMenu.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Akif\Desktop\mvvm1\Shared\NavMenu.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Akif\Desktop\mvvm1\Shared\NavMenu.razor"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Akif\Desktop\mvvm1\Shared\NavMenu.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Akif\Desktop\mvvm1\Shared\NavMenu.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Akif\Desktop\mvvm1\Shared\NavMenu.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Akif\Desktop\mvvm1\Shared\NavMenu.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Akif\Desktop\mvvm1\Shared\NavMenu.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Akif\Desktop\mvvm1\Shared\NavMenu.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Akif\Desktop\mvvm1\Shared\NavMenu.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Users\Akif\Desktop\mvvm1\Shared\NavMenu.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Akif\Desktop\mvvm1\Shared\NavMenu.razor"
using System.Net.Sockets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Akif\Desktop\mvvm1\Shared\NavMenu.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Akif\Desktop\mvvm1\Shared\NavMenu.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Akif\Desktop\mvvm1\Shared\NavMenu.razor"
using Microsoft.Data.SqlClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Akif\Desktop\mvvm1\Shared\NavMenu.razor"
using System.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Akif\Desktop\mvvm1\Shared\NavMenu.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Akif\Desktop\mvvm1\Shared\NavMenu.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\Akif\Desktop\mvvm1\Shared\NavMenu.razor"
                                   
    private bool collapseNavMenu = true;
    [Inject]
    public ProtectedLocalStorage localStorage { get; set; }
    public string resultCookieValue { get; set; } = "";
    public string UserID { get; set; } = "";
    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
