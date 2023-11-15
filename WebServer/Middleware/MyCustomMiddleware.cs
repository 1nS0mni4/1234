public class MyCustomMiddleware {
    private readonly RequestDelegate _next;

    public MyCustomMiddleware(RequestDelegate next) {
        _next = next;
    }

    // IMessageWriter is injected into InvokeAsync
    public async Task InvokeAsync(HttpContext httpContext) { 
        //TODO: 검증단계
        
        await _next(httpContext);
    }
}

public static class MyCustomMiddlewareExtensions {
    public static IApplicationBuilder UseMyCustomMiddleware(
        this IApplicationBuilder builder) {
        return builder.UseMiddleware<MyCustomMiddleware>();
    }
}