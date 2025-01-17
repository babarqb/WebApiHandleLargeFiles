using Microsoft.AspNetCore.Mvc;
using WebApiHandleLargeFiles.Utilities;

namespace WebApiHandleLargeFiles.Controllers;

public class FileController : Controller
{
    private readonly IFileService _fileService;

    public FileController(IFileService fileService)
    {
        _fileService = fileService;
    }

    [HttpPost("upload-stream-multipartreader")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status415UnsupportedMediaType)]
    [MultipartFormData]
    [DisableFormValueModelBinding]
    public async Task<IActionResult> Upload()
    {
        var fileUploadSummary = await _fileService.UploadFileAsync(Request.Body, Request.ContentType);
        return CreatedAtAction(nameof(Upload), fileUploadSummary);
    }
}