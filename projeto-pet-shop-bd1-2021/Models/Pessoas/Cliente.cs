﻿namespace projeto_pet_shop_bd1_2021.Models.Pessoas
{
    public class Cliente
    {
        public long Id { get; set; }
        public long IdPessoa { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}