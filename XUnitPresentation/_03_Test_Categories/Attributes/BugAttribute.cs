using Xunit;

namespace XUnitPresentation._03_Test_Categories.Attributes
{
    public class BugAttribute : TraitAttribute
    {
        public BugAttribute(string bugId) : base("Bug", bugId)
        {
            
        }
    }
}