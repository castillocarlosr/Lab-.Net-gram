using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage.Blob;
using NetGram.Models;
using NetGram.Models.Interfaces;

namespace NetGram.Pages.Work
{
    public class ManageModel : PageModel
    {
        private readonly IWorkGram _workGram;

        [FromRoute]
        public int? ID { get; set; }

        [BindProperty]
        public WorkGram WorkGram { get; set; }

        [BindProperty]
        public IFormFile Image { get; set; }

        //Does not have to be explicit but just in case
        public Models.Utilities.Blob BlobImage { get; set; }

        public ManageModel(IWorkGram workGram, IConfiguration configuration)
        {
            _workGram = workGram;
            //Blob storage to be referenced
            BlobImage = new Models.Utilities.Blob(configuration);
        }

        public async Task OnGet()
        {
            WorkGram = await _workGram.FindWorkGram(ID.GetValueOrDefault()) ?? new WorkGram();
        }

        public async Task<IActionResult> OnPost()
        {
            var work = await _workGram.FindWorkGram(ID.GetValueOrDefault()) ?? new WorkGram();

            work.UserName = WorkGram.UserName;
            work.Title = WorkGram.Title;
            work.URL = WorkGram.URL;
            work.Views = WorkGram.Views;
            work.Comments = WorkGram.Comments;

            if(Image != null)
            {
                //to create a temporaru file path
                var filePath = Path.GetTempFileName();

                using(var stream = new FileStream(filePath, FileMode.Create))
                {
                    await Image.CopyToAsync(stream);
                }

                //Get Container
                var containerWork = await BlobImage.GetContainer("gram");

                //Upload image
                BlobImage.UploadFile(containerWork, Image.FileName, filePath);

                //Save into database
                CloudBlob blob = await BlobImage.GetBlob(Image.FileName, containerWork.Name);

                work.URL = blob.Uri.ToString();
            }

            await _workGram.SaveAsync(work);

            return RedirectToPage("/Index");
        }

        public async Task<IActionResult> OnPostDelete()
        {
            await _workGram.DeleteAsync(ID.Value);
            return RedirectToPage("/Index");
        }
    }
}