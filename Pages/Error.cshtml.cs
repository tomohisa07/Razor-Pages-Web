using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace RazorPagesMovie.Pages
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    [IgnoreAntiforgeryToken]
    public class ErrorModel : PageModel
    {
        #pragma warning disable CS8632 // '#nullable' ���߃R���e�L�X�g���̃R�[�h�ł̂݁ANull ���e�Q�ƌ^�̒��߂��g�p����K�v������܂��B
        public string? RequestId { get; set; }
        #pragma warning restore CS8632 // '#nullable' ���߃R���e�L�X�g���̃R�[�h�ł̂݁ANull ���e�Q�ƌ^�̒��߂��g�p����K�v������܂��B

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        private readonly ILogger<ErrorModel> _logger;

        public ErrorModel(ILogger<ErrorModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        }
    }
}