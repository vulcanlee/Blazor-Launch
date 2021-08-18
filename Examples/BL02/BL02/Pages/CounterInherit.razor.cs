using Microsoft.AspNetCore.Components;

namespace BL02.Pages
{
    public class CounterInheritBase : ComponentBase
    {
        public int currentCount = 0;

        public void IncrementCount()
        {
            currentCount++;
        }
    }
}
