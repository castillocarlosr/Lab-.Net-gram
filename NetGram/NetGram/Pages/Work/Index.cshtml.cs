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
    public class IndexModel : PageModel
    {
        private readonly IWorkGram _workGram;

        public IndexModel(IWorkGram workGram)
        {
            _workGram = workGram;
        }

        [FromRoute]
        public int ID { get; set; }

        public WorkGram WorkGram { get; set; }

        /// <summary>
        /// Will get the specific data for the ID that is sent in
        /// </summary>
        /// <returns>Specific WorkGram data</returns>
        public async Task OnGetAsync()
        {
            WorkGram = await _workGram.FindWorkGram(ID);
        }
    }
}