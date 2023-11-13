namespace TesteTecnicoImobiliaria.WEB.Models
{
    public class ImovelViewModel
    {
        public List<ImovelModel> Imoveis { get; set; }
        public ImovelModel Imovel { get; set; }
    }

    public class ImovelModel
    {

        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public int IdTipoImovel { get; set; }
        public string ValorImovel { get; set; }
        public string DataPublicacao { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
    }
}
