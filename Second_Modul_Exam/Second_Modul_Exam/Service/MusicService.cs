using Second_Modul_Exam.DataAccess.Entities;
using Second_Modul_Exam.Repository;
using Second_Modul_Exam.Service.DTO;

namespace Second_Modul_Exam.Service
{
    public class MusicService : IMusicService
    {
        private readonly IMusicRepository _musicRepository;

        public MusicService()
        {
            _musicRepository = new MusicRepository();
        }
        public Guid AddMusic(Music music)
        {
            music.id = Guid.NewGuid();
            _musicRepository.AddMusic(music);
            return music.id;

        }

        public void DeleteMusic(Music music)
        {
            _musicRepository.DeleteMusic(music);
        }

        public List<MusicDTO> GetAllMusic()
        {
            var AllMusic = _musicRepository.GetAllMusic();
            List<MusicDTO> DTOmusic = new List<MusicDTO>();
            foreach (var music in AllMusic)
            {
                DTOmusic.Add(ConverToDTO(music));
            }
            return DTOmusic;
        }

        public List<MusicDTO> GetAllMusicAboveSize(double minSize)
        {

        }

        public List<MusicDTO> GetAllMusicByAuthorName(string name)
        {
            var All = _musicRepository.GetAllMusic();
            var DTO = new List<MusicDTO>();
            List<MusicDTO> result = new List<MusicDTO>();

            for (int i = 0; i < All.Count; i++)
            {
                DTO.Add(ConverToDTO(All[i]));

            }

            foreach (var music in DTO)
            {
                if (music.AuthorName == name)
                {
                    result.Add(music);
                }
            }
            return result;

        }

        public List<string> GetAllUniqueAuthors()
        {
            throw new NotImplementedException();
        }

        public MusicDTO GetMostLikedMusic()
        {
            var All = _musicRepository.GetAllMusic();
            int max = 0;
            MusicDTO MostLiked = new MusicDTO();
            foreach (var music in All)
            {
                if (music.QuentityLikes > max)
                {
                    max = music.QuentityLikes;
                }
                MostLiked = ConverToDTO(music);
            }
            return MostLiked;
        }

        public List<MusicDTO> GetMusicByDescriptionKeyword(string keyword)
        {
            var AllMusic = _musicRepository.GetAllMusic();
            List<MusicDTO> SamaKeyword = new List<MusicDTO>();
            foreach (var music in AllMusic)
            {
                if (music.Description.Contains(keyword))
                {
                    SamaKeyword.Add(ConverToDTO(music));
                }
            }
            return SamaKeyword;

        }

        public MusicDTO GetMusicById(Guid id)
        {
            throw new NotImplementedException();
        }

        public MusicDTO GetMusicByName(string name)
        {
            var AllMusic = _musicRepository.GetAllMusic();
            MusicDTO music = new MusicDTO();
            foreach (var items in AllMusic)
            {
                if (items.Name == name)
                {
                    music = ConvertDTOstring(items);
                }
            }
            return music;
        }


        private MusicDTO ConvertDTOstring(Music music)
        {
            var result = new MusicDTO()
            {
                Name = music.Name,
                Description = music.Description,
                AuthorName = music.AuthorName,
            };
            return result;
        }

        public List<MusicDTO> GetMusicWithLikesInRange(int minLikes, int maxLikes)
        {
            var AllMusic = _musicRepository.GetAllMusic();
            var ToDTO = new List<MusicDTO>();
            for (int i = 0; i < AllMusic.Count; i++)
            {
                ToDTO.Add(ConverToDTO(AllMusic[i]));

            }

            List<MusicDTO> InRange = new List<MusicDTO>();





        }

        public List<MusicDTO> GetTopMostLikedMusic(int count)
        {
            List<Music> MostLiked = new List<Music>();
            var AllMusic = _musicRepository.GetAllMusic();
            foreach (var item in AllMusic)
            {

            }
        }

        public double GetTotalMusicSizeByAuthor(string authorName)
        {
            throw new NotImplementedException();
        }

        public bool UpdateMusic(Music music)
        {
            var result = _musicRepository.UpdateMusic(music);
            if (result == false)
            {
                return false;
            }
            return true;
        }

        private MusicDTO ConverToDTO(Music music)
        {
            MusicDTO DTO = new MusicDTO()
            {
                id = music.id,
                Name = music.Name,
                MB = music.MB,
                AuthorName = music.AuthorName,
                Description = music.Description,
                QuentityLikes = music.QuentityLikes,
            };
            return DTO;

        }


    }
}
