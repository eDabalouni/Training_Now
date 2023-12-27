using TrainingAPIs.Models.Dto;

namespace TrainingAPIs.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
        {
            new VillaDTO{Id=1,Name="Pool View",Occupancy=443,Aquft=99},
            new VillaDTO{Id=2,Name="Beach View",Occupancy=444,Aquft=100}
        };
    }
}
