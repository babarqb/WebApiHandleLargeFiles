namespace WebApiHandleLargeFiles.Dto;

public class FileUploadSummary
{
    public int TotalFilesUploaded { get; set; }
    public string? TotalSizeUploaded { get; set; }
    public List<string>? FilePaths { get; set; }
    public List<string>? NotUploadedFiles { get; set; }
}