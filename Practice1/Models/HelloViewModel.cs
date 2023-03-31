namespace Practice1.Models;

public class HelloViewModel
{
    public string Name { get; set; } = string.Empty;

    public string GetHello()
    {
        return !string.IsNullOrWhiteSpace(this.Name)
                ? $"Hello, {this.Name}!"
                : "Hello no name meat";
    }
}