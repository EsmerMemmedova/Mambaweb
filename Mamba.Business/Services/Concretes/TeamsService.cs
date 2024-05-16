using Mamba.Business.Services.Abstracts;
using Mamba.Core.Models;
using Mamba.Core.RepostoryAbstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mamba.Business.Services.Concretes
{
    public class TeamsService : ITeamsService
    {

        private readonly ITeamsRepostory _teamsRepostory;

        public TeamsService(ITeamsRepostory teamsRepostory)
        {
            _teamsRepostory = teamsRepostory;
        }

        public void AddTeam(Team team)
        {
            if (!team.ImgFile.ContentType.Contains("image/"))
                _teamsRepostory.Add(team);

            _teamsRepostory.Commit();
        }

        public List<Team> GetAllTeams(Func<Team, bool>? func = null)
        {
            throw new NotImplementedException();
        }

        public Team GetTeam(Func<Team, bool>? func = null)
        {
            throw new NotImplementedException();
        }

        public void RemoveTeam(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Team team)
        {
            throw new NotImplementedException();
        }
    }
}
