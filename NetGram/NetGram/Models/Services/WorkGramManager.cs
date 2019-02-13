using Microsoft.EntityFrameworkCore;
using NetGram.Data;
using NetGram.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetGram.Models.Services
{
    public class WorkGramManager : IWorkGram
    {
        private readonly WorkGramDbContext _context;

        public WorkGramManager(WorkGramDbContext context)
        {
            _context = context;
        }

        public async Task DeleteAsync(int id)
        {
            WorkGram workGram = await _context.WorkGrams.FindAsync(id);
            if(workGram != null)
            {
                _context.Remove(workGram);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<WorkGram> FindWorkGram(int id)
        {
            WorkGram workGram = await _context.WorkGrams.FirstOrDefaultAsync(wg => wg.ID == id);
            return workGram;
        }

        public async Task<List<WorkGram>> GetWorkGrams()
        {
            return await _context.WorkGrams.ToListAsync();
        }

        public async Task SaveAsync(WorkGram workGram)
        {
            //Creating a new WorkGram if database does not exsist.
            if(await _context.WorkGrams.FirstOrDefaultAsync(make => make.ID == workGram.ID) == null)
            {
                _context.WorkGrams.Add(workGram);
            }
            else //Database does exsist, so go to update instead.
            {
                _context.WorkGrams.Update(workGram);
            }
            await _context.SaveChangesAsync();
        }
    }
}
