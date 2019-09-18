using MGroup.XFEM.Utilities;

namespace MGroup.XFEM.Enrichments.Functions
{
    public interface IHeavisideFunction2D : IEnrichmentFunction2D
    {
        double EvaluateAt(double signedDistance);
        EvaluatedFunction2D EvaluateAllAt(double signedDistance);
    }
}
