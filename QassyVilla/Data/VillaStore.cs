using QassyVilla.Models.DTO;

namespace QassyVilla.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
            {
                new VillaDTO{Id=1, Name="Sandy Resort"},
                new VillaDTO{Id=2, Name="Massive Resort"}
            };
    }
}
