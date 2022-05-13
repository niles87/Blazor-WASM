namespace Blazor_WASM.Shared {
  public class Blog {
    public DateTime Date { get; set; } = DateTime.Now;
    public string Title { get; set; } 
    public string Content { get; set; } 
    public string Username { get; set; }
    public string UserId { get; set; }
  }
}
