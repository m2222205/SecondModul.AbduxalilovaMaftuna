using Second_Modul_Exam.DataAccess.Entities;

namespace Second_Modul_Exam.Service.DTO.ExtensionMethods
{
    public static class GetMusicKB
    {
        public static double MBtoKB(this Music music)
        {
            var MB = music.MB;
            var result = MB * 1024;
            return result;
        }

    }


}
