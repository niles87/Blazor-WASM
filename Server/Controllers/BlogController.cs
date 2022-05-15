using Blazor_WASM.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Blazor_WASM.Server.Controllers;
[ApiController]
[Route("/api/[controller]")]
public class BlogController : ControllerBase {

  private List<Blog> fakeBlogs = new() {
    new Blog() { Title = "New post", Content = "First Post", UserId = "1234", Username = "FirstUser" },
    new Blog() { Title = "My Second post", Content = "Second One!!", UserId = "123", Username = "Second User" },
    new Blog() { Title = "Hello world", Content = "Well hello world", UserId = "1234", Username = "FirstUser" },
  };

  private readonly ILogger<BlogController> _logger;

  public BlogController(ILogger<BlogController> logger) {
    _logger = logger;
  }

  [HttpGet]
  public async Task<IEnumerable<Blog>> GetAsync() {
    return fakeBlogs.ToArray();
  }

  [HttpPost]
  public async Task<Blog> PostAsync(CreateBlogDto blog) {
    Blog newPost = new() {
      Title = blog.Title,
      Content = blog.Content,
      UserId = blog.UserId,
      Username = blog.Username,
      Date = DateTime.Now,
    };
    fakeBlogs.Add(newPost);

    return newPost;
  }
}