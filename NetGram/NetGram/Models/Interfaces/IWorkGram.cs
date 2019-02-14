using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetGram.Models.Interfaces
{
    public interface IWorkGram
    {
        //Delete
        Task DeleteAsync(int id);

        //Find
        Task<WorkGram> FindWorkGram(int id);

        //Get All
        Task<List<WorkGram>> GetWorkGrams();

        //Save
        Task SaveAsync(WorkGram workGram);
    }
}
