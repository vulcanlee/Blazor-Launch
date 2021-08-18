using Microsoft.AspNetCore.Components;

namespace BLA2.Pages
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
