namespace ECommerce.Shared.Helpers;

public static class FileHelper
{
    public static string GetUniqueFileName(string fileName)
    {
        var extension = Path.GetExtension(fileName);

        var uniqueName =
            $"{Guid.NewGuid()}{extension}";

        return uniqueName;
    }
}