using Second_Modul_Exam.DataAccess.Entities;
using Second_Modul_Exam.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Modul_Exam.Service
{
    public interface IMusicService
    {
        Guid AddMusic(Music music);
        void DeleteMusic(Music music);
        bool UpdateMusic(Music music);
        List<MusicDTO> GetAllMusic();
        MusicDTO GetMusicById(Guid id);
        List<MusicDTO> GetAllMusicByAuthorName(string name);
        MusicDTO GetMostLikedMusic();
        MusicDTO GetMusicByName(string name);
        List<MusicDTO> GetAllMusicAboveSize(double minSize);
        List<MusicDTO> GetTopMostLikedMusic(int count);
        List<MusicDTO> GetMusicByDescriptionKeyword(string keyword);
        List<MusicDTO> GetMusicWithLikesInRange(int minLikes, int maxLikes);
        List<string> GetAllUniqueAuthors();
        double GetTotalMusicSizeByAuthor(string authorName);

    }
}
