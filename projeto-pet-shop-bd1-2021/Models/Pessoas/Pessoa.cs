using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_pet_shop_bd1_2021.Models.Pessoas
{
    public class Pessoa : BaseEntity
    {
        [Display(Name ="CPF")]
        public string Cpf { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Display(Name = "Logradouro")]
        public string EnderecoLogradouro { get; set; }

        [Display(Name = "Número da casa")]
        public string EnderecoNumero { get; set; }

        [Display(Name = "Complemento")]
        public string EnderecoComplemento { get; set; }

        [Display(Name = "CEP")]
        public string EnderecoCep { get; set; }

        [Display(Name = "Cidade")]
        public string EnderecoCidade { get; set; }

        [Display(Name = "Estado")]
        public string EnderecoEstado { get; set; }
    }
}