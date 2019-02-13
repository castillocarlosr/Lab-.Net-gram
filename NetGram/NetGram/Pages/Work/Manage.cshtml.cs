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

        public ManageModel(IWorkGram workGram)
        {
            _workGram = workGram;
        }

        public async Task OnGet()
        {
            WorkGram = await _workGram.FindWorkGram(ID.GetValueOrDefault()) ?? new WorkGram();
        }
    }
}