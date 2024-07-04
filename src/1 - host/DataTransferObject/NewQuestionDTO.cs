namespace MinhaPrimeiraAPI.DataTransferObject
{
    public class NewQuestionDTO
    {
        public string Description { get; set; }

        public IList<NewOptionDTO> Options { get; set; }
    }
}
