using Blazor_WASM.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Blazor_WASM.Server.Controllers;
[ApiController]
[Route("[controller]")]
public class BlogController : ControllerBase {

  private static readonly Blog[] fakeBlogs = new Blog[] {
    new Blog() { Title = "New post", Content = "First Post", UserId = "1234", Username = "FirstUser" },
    new Blog() { Title = "My Second post", Content = "Second One!!", UserId = "123", Username = "Second User" },
    new Blog() { Title = "Hello world", Content = "Well hello world", UserId = "1234", Username = "FirstUser" }, };

  private readonly ILogger<BlogController> _logger;

  public BlogController(ILogger<BlogController> logger) {
    _logger = logger;
  }

  [HttpGet]
  public IEnumerable<Blog> Get() {
    return fakeBlogs.ToArray();
  }
}