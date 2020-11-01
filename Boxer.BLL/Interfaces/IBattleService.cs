using Boxer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxer.BLL.Interfaces
{
    public interface IBattleService
    {
        Task<List<Battle>> GetAllBattles();
        Task<List<Battle>> GetBattlesByBoxerName(string boxerName);
    }
}
