using System.Text;

namespace LibraryApis.DotNet6;

public static class LowLevelFileApisSample
{
    public static async Task Run()
    {
        var file = File.OpenHandle(
            "sample.txt", FileMode.Open, FileAccess.Read, FileShare.Read, FileOptions.Asynchronous);

        var buffer = new Memory<byte>(new byte[100]);
        await RandomAccess.ReadAsync(file, buffer, 0);
        var content = Encoding.UTF8.GetString(buffer.Span);

        Console.WriteLine($"    File.OpenHandle - {content}");
    }
}
