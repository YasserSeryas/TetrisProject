// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\Pages\Tetris.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tetris")]
    public partial class Tetris : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\Pages\Tetris.razor"
       
      Grid grid = new Grid();
      int l;
       private int Height { get; set; }
    private int Width { get; set;}
    private int NewH { get; set; }
    private int NewW { get; set; }
 
   
    private void GetValue()

    {

        NewH = Height;
        NewW = Width;
       
        grid.Height=NewH;
        grid.Width=NewW;
    }


      
    
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
