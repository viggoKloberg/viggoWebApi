namespace viggoWebApi.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Viggo";
        public int Hp { get; set; } = 100;
        public int Strenght { get; set; } = 10;
        public int defence { get; set; } = 10;
        public int Intelligence { get; set; } = 10;

        public RpgClass Class { get; set; } = RpgClass.knight;
    }
}