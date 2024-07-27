using WebApiHandleLargeFiles.Dto;

public interface IFileService
{
    Task<FileUploadSummary> UploadFileAsync(Stream body, string contentType);
}