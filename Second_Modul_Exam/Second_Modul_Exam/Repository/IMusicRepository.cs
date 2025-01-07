using Second_Modul_Exam.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Modul_Exam.Repository
{
    public interface IMusicRepository
    {
        Guid AddMusic(Music music);
        bool DeleteMusic(Music music);
        bool UpdateMusic(Music music);
        Music GetById(Guid id);
        List<Music> GetAllMusic();   

    }
}
