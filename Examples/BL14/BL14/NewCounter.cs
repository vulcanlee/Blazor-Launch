namespace BL14
{
    [Microsoft.AspNetCore.Components.RouteAttribute("/NewCounter")]
    public partial class NewCounter : Microsoft.AspNetCore.Components.ComponentBase
    {
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            int mixCodeBlockCount = 0;
            void MixCodeMethod()
            {
                __builder.OpenElement(0, "p");
                __builder.AddMarkupContent(1, "混和式 count: ");
                __builder.AddContent(2, mixCodeBlockCount);
                __builder.CloseElement();
            }
            mixCodeBlockCount = currentCount;
            MixCodeMethod();
            __builder.AddMarkupContent(3, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(4, "p");
            __builder.AddContent(5, "Current count: ");
            __builder.AddContent(6,currentCount);
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "btn btn-primary");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create
                <Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this,IncrementCount));
            __builder.AddContent(11, "Click me");
            __builder.CloseElement();
        }
        private int currentCount = 0;
        private void IncrementCount() { currentCount++; }
    }
}
