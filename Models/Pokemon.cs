using System.Text.Json.Serialization;

namespace CustomPokedex.Models
{
    public class Pokemon
    {
        [JsonPropertyName("abilities")]
        public List<string> Abilities { get; set; }

        [JsonPropertyName("against_bug")]
        public double AgainstBug { get; set; }

        [JsonPropertyName("against_dark")]
        public double AgainstDark { get; set; }

        [JsonPropertyName("against_dragon")]
        public double AgainstDragon { get; set; }

        [JsonPropertyName("against_electric")]
        public double AgainstElectric { get; set; }

        [JsonPropertyName("against_fairy")]
        public double AgainstFairy { get; set; }

        [JsonPropertyName("against_fight")]
        public double AgainstFight { get; set; }

        [JsonPropertyName("against_fire")]
        public double AgainstFire { get; set; }

        [JsonPropertyName("against_flying")]
        public double AgainstFlying { get; set; }

        [JsonPropertyName("against_ghost")]
        public double AgainstGhost { get; set; }

        [JsonPropertyName("against_grass")]
        public double AgainstGrass { get; set; }

        [JsonPropertyName("against_ground")]
        public double AgainstGround { get; set; }

        [JsonPropertyName("against_ice")]
        public double AgainstIce { get; set; }

        [JsonPropertyName("against_normal")]
        public double AgainstNormal { get; set; }

        [JsonPropertyName("against_poison")]
        public double AgainstPoison { get; set; }

        [JsonPropertyName("against_psychic")]
        public double AgainstPsychic { get; set; }

        [JsonPropertyName("against_rock")]
        public double AgainstRock { get; set; }

        [JsonPropertyName("against_steel")]
        public double AgainstSteel { get; set; }

        [JsonPropertyName("against_water")]
        public double AgainstWater { get; set; }

        [JsonPropertyName("attack")]
        public int Attack { get; set; }

        [JsonPropertyName("base_egg_steps")]
        public int BaseEggSteps { get; set; }

        [JsonPropertyName("base_happiness")]
        public int BaseHappiness { get; set; }

        [JsonPropertyName("base_total")]
        public int BaseTotal { get; set; }

        [JsonPropertyName("capture_rate")]
        public string CaptureRate { get; set; }

        [JsonPropertyName("classfication")]
        public string Classification { get; set; }

        [JsonPropertyName("defense")]
        public int Defense { get; set; }

        [JsonPropertyName("experience_growth")]
        public int ExperienceGrowth { get; set; }

        [JsonPropertyName("height_m")]
        public double? HeightMeters { get; set; }

        [JsonPropertyName("hp")]
        public int HP { get; set; }

        [JsonPropertyName("japanese_name")]
        public string JapaneseName { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("percentage_male")]
        public double? PercentageMale { get; set; }

        [JsonPropertyName("pokedex_number")]
        public int PokedexNumber { get; set; }

        [JsonPropertyName("sp_attack")]
        public int SpAttack { get; set; }

        [JsonPropertyName("sp_defense")]
        public int SpDefense { get; set; }

        [JsonPropertyName("speed")]
        public int Speed { get; set; }

        [JsonPropertyName("type1")]
        public string Type1 { get; set; }

        [JsonPropertyName("type2")]
        public string Type2 { get; set; }

        [JsonPropertyName("weight_kg")]
        public double? WeightKg { get; set; }

        [JsonPropertyName("generation")]
        public int Generation { get; set; }

        [JsonPropertyName("is_legendary")]
        public int IsLegendary { get; set; }
    }
}
