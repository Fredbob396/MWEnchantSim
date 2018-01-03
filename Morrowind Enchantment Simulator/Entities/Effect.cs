namespace Morrowind_Enchantment_Simulator
{
    public class Effect
    {
        public string CastStyle { get; set; } = "";
        public float BaseCost { get; set; } = 1;
        public float MinMagnitude { get; set; } = 1;
        public float MaxMagnitude { get; set; } = 1;
        public float Duration { get; set; } = 1;
        public float AreaOfEffect { get; set; } = 1;
    }
}
