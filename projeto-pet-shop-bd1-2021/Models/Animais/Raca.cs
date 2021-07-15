namespace projeto_pet_shop_bd1_2021.Models.Animais
{
    public class Raca
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public string Caracteristica { get; set; }
        public long IdTipo { get; set; }
        public TipoAnimal TipoAnimal { get; set; }
    }
}