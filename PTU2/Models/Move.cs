﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable

namespace The_Prodigal_Son.Models
{
    public partial class Move
    {
        public int? PokemonId { get; set; }
        public string MoveName { get; set; }
        public string MoveCategory { get; set; }
        public string DamageRoll { get; set; }
        public string MoveType { get; set; }
        public int? Ac { get; set; }
        public bool IsSpecial { get; set; }
        public string SpecialEffect { get; set; }
        public string SpecialCondition { get; set; }

        public virtual TypeEffect MoveTypeNavigation { get; set; }
        public virtual PokemonOwned Pokemon { get; set; }
    }
}