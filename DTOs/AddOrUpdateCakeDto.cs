public class AddOrUpdateCakeDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public string PictureURL { get; set; }
    public FileData FileUploadInfo { get; set; }
}

public class FileData
{
    public byte[] ImageBytes { get; set; }
    public string FileName { get; set; }
    public string FileType { get; set; }
    public long FileSize { get; set; }
}

