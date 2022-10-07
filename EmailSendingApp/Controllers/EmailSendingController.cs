using EmailSendingApp.Services;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;

namespace EmailSendingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailSendingController : ControllerBase
    {
        private readonly EmailService _emailService;
        public EmailSendingController(EmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public IActionResult SendEmail(EmailDto request)
        {
            _emailService.SendEmail(request);


            return Ok();
        }
    }

}