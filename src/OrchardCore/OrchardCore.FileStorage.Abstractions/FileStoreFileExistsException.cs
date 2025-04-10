namespace OrchardCore.FileStorage;

public class FileStoreFileExistsException : Exception
{
    public FileStoreFileExistsException(string message) : base(message)
    {
    }

    public FileStoreFileExistsException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
