namespace MinhaPrimeiraAPI.DataTransferObject
{
    public class NewOptionDTO 
    {
        public string Description { get; set; }

        public string? IsCorrect { get; set; }

        public bool IsCorrectValue => IsCorrect == "on";
    }
}
