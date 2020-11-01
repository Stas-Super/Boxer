using Boxer.BLL.Interfaces;
using Boxer.DAL.Repositories;
using Boxer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxer.BLL.Services
{
    public class BattleService : IBattleService
    {
        BattleRepository repo = new BattleRepository();
        public async Task<List<Battle>> GetAllBattles()
        {
            return await repo.GetAll();   
        }
        public async Task<List<Battle>> GetWinBattlesByBoxerName(string boxerName) 
        {
            boxerName = boxerName.ToLower();
            return await repo.GetAll(b => b.First.ToLower().Equals(boxerName));
        }

        public async Task<List<Battle>> GetBattlesByBoxerName(string boxerName)
        {
            boxerName = boxerName.ToLower();
            return await repo.GetAll(b => b.First.ToLower().Equals(boxerName) || b.Second.ToLower().Equals(boxerName));   
        }
    }
}
