#pragma checksum "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\Pages\Tetris.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ffb15b2bc81ffbbc516bba3ec51ee63cfb12cdc"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>TETRIS</h1>\r\n\r\n\r\n<a href></a>\r\n\r\n ");
            __builder.AddMarkupContent(1, "<a href=\"/tetris/settings\" class=\"a\">SETTINGS</a>\r\n");
            __builder.OpenElement(2, "a");
            __builder.AddAttribute(3, "href", "/tetris");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\Pages\Tetris.razor"
                            play

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "class", "");
            __builder.AddContent(6, "PAUSE");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(8, "<a href=\"/\" class=\"a\">LEAVE</a> \r\n\r\n\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "tetris-container");
            __builder.AddAttribute(13, "tabindex", "0");
#nullable restore
#line 37 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\Pages\Tetris.razor"
             for (int i = grid.Height; i >= 1; i--)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "tetris-row");
#nullable restore
#line 41 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\Pages\Tetris.razor"
                     for (int j = 1; j <= grid.Width; j++)
                     
                    {



                   
                        l++;
                   
                   
                        
                        

                        
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\Pages\Tetris.razor"
                         if(l == 5 || l == 6 ||l==15 ||l==16){


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, "<div class=\"Tetromino-O\"></div>");
#nullable restore
#line 58 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\Pages\Tetris.razor"
                         
                        }else{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "id", 
#nullable restore
#line 60 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\Pages\Tetris.razor"
                                     l

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "class", "tetris-cell ");
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\Pages\Tetris.razor"

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\Pages\Tetris.razor"
                         
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 66 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\Pages\Tetris.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.AddMarkupContent(21, "<h3>Settings</h3>\r\n\r\n \r\n");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 74 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\Pages\Tetris.razor"
              Width

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Width = __value, Width));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\Pages\Tetris.razor"
              Height

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Height = __value, Height));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "  \r\n");
            __builder.OpenElement(30, "p");
            __builder.AddContent(31, "Current settings:");
            __builder.AddContent(32, 
#nullable restore
#line 76 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\Pages\Tetris.razor"
                     Width

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(33, ", ");
            __builder.AddContent(34, 
#nullable restore
#line 76 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\Pages\Tetris.razor"
                             Height

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(35, " (10 by 20 default)");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\Pages\Tetris.razor"
                   GetValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(39, "Change ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 79 "C:\Users\Serya\OneDrive\Documents\GitHub\TetrisProject\BlazorApp\Pages\Tetris.razor"
       

    Tetromino tetromino = new Tetromino();
    
    int O;

    private int HeightTetrominoO {get; set; }

    private int WidthTetrominoO {get; set; }

    private int NewHT {get; set; }

    private int NewWT {get; set; }

int l;


      Grid grid = new Grid();
      
       private int Height { get; set; }
    private int Width { get; set;}
    private int NewH { get; set; }
    private int NewW { get; set; }
 
   
    private void GetValue()

    {
        NewHT = Height;

        NewWT = Width;

        NewH = Height;
        NewW = Width;
       
        grid.Height=NewH;
        grid.Width=NewW;

        tetromino.HeightTetrominoO = NewHT;
        tetromino.WidthTetrominoO = NewWT;
    }
     void play() {
         
    
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591