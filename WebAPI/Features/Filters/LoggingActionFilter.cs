namespace WebAPI.Features.Filters
{
    using Microsoft.AspNetCore.Mvc.Filters;

    public class LoggingActionFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine("Before Action Execution");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("After Action Execution");
        }
    }
}
