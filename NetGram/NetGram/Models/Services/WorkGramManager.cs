using NetGram.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetGram.Models.Services
{
    public class WorkGramManager : IWorkGram
    {
        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<WorkGram> FindWorkGram(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<WorkGram>> GetWorkGrams()
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(WorkGram workGram)
        {
            throw new NotImplementedException();
        }
    }
}
