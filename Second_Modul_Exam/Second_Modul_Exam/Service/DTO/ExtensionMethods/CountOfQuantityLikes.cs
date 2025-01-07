namespace Second_Modul_Exam.Service.DTO.ExtensionMethods
{
    public static class CountOfQuantityLikes
    {
        public static int AllQuantityLikes(List<MusicDTO> list)
        {
            var result = 0;
            foreach (var music in list)
            {
                result += music.QuentityLikes;
            }
            return result;
        }


    }
}
