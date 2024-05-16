using Mamba.Business.Exteptions;
using Mamba.Business.Services.Abstracts;
using Mamba.Core.Models;
using Mamba.Core.RepostoryAbstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mamba.Business.Services.Concretes
{
    public class TeamsService : ITeamsService
    {

        private readonly ITeamsRepostory _teamsRepostory;
        private readonly IWebHostEnviroment _webHostEnviroment;
        public TeamsService(ITeamsRepostory teamsRepostory)
        {
            _teamsRepostory = teamsRepostory;
        }

       
        public void AddTeam(Team team)
        {
            if (!team.ImgFile.ContentType.Contains("image/"))
                throw new FileContentTypeExteption("ImageFile", "File content type error!");
            if (team.ImgFile.Length > 2097152)
                throw new FileSizeExteption("ImageFile", "File size error!");
            string path = @"C:\Users\2022\Desktop\NlayerMamba\NlayerMamba\wwwroot\Upload\Team\";
            string filename = team.ImgFile.FileName;

           using( FileStream stream = new FileStream(path,FileMode.Create))
            {
                team.ImgFile.CopyTo(stream);
            }
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
