namespace MinhaPrimeiraAPI.DataTransferObject
{
    public class NewGameDTO
    {
        public string Theme { get; set; }

        public IList<NewQuestionDTO> Questions { get; set; }
    }
}
