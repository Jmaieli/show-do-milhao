namespace MinhaPrimeiraAPI.DataTransferObject
{
    public class GameDTO
    {
        public int GameId { get; set; }

        public string Theme { get; set; }

        public IList<QuestionDTO> Questions { get; set; }

        //public IList<Player> Players { get; set; }

        //public IList<PlayerAnswer> PlayerAnswers { get; set; }

    }
}