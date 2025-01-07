using Second_Modul_Exam.DataAccess.Entities;
using System.Text.Json;

namespace Second_Modul_Exam.Repository
{
    public class MusicRepository : IMusicRepository
    {
        private List<Music> musics;
        private string path;

        public MusicRepository()
        {
            musics = new List<Music>();
            path = "../../../DataAccess/Data/MusicJson";
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "[]");
            }
            musics = GetAllMusic();
        }

        public Guid AddMusic(Music music)
        {
            musics.Add(music);
            SavaData();
            return music.id;
        }

        public bool DeleteMusic(Music music)
        {
            var exists = GetById(music.id);
            if (exists == null)
            {
                return false;
            }
            musics.Remove(exists);
            SavaData();
            return true;

        }

        public List<Music> GetAllMusic()
        {
            var copy = File.ReadAllText(path);
            var deserialize = JsonSerializer.Deserialize<List<Music>>(copy);
            return deserialize;
        }

        public Music GetById(Guid id)
        {
            foreach (var music in musics)
            {
                if (music.id == id)
                {
                    return music;
                }
            }
            return null;
        }

        public bool UpdateMusic(Music music)
        {
            var exists = GetById(music.id);
            if (exists == null)
            {
                return false;
            }
            var index = musics.IndexOf(music);
            musics[index] = music;
            SavaData();
            return true;
        }

        private void SavaData()
        {
            var MusicJson = JsonSerializer.Serialize(musics);
            File.AppendAllText(path, MusicJson);
        }

    }
}
