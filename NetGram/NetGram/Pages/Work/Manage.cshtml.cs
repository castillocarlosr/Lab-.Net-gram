using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public ManageModel(IWorkGram workGram)
        {
            _workGram = workGram;
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