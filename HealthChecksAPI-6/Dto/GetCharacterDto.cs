namespace HealthChecksAPI_6.Dto
{
    public class GetCharacterDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Kalenski";
        public int Strength { get; set; } = 10;
        public int Defense { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
    }
}
