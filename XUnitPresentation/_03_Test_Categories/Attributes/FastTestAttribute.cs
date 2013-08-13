using Xunit;

namespace XUnitPresentation._03_Test_Categories.Attributes
{
    public class FastTestAttribute : TraitAttribute
    {
        public FastTestAttribute() : base("Category", "Fast Running Test")
        {
            
        }
    }
}