using Mamba.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mamba.Business.Services.Abstracts
{
    public interface ITeamsService
    {
        void RemoveTeam(int id);
        void AddTeam(Team team);
        void Update(int id, Team team;
        Team GetTeam(Func<Team,bool>? func=null);
        List<Team> GetAllTeams(Func<Team,bool>? func=null);

    }
}
