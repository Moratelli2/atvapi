namespace ATVAPIRELACIONAMENTO1109.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string quantidade { get; set; }

        public Produto Produto { get; set; }

    }
}
