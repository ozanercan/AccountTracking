using Core.Entities.Abstract;

namespace Entities.Dtos
{
    public class CurrentCardAndForeignIndividualAddDto : IDto
    {
        public CurrentCardAddDto CurrentCardAddDto { get; set; }
        public IndividualCurrentCardAddDto IndividualCurrentCardAddDto { get; set; }
        public ForeignIndividualCurrentCardAddDto ForeignIndividualCurrentCardAddDto { get; set; }
    }
}
