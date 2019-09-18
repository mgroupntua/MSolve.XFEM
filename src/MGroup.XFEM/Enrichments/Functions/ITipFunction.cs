using MGroup.MSolve.Geometry.Coordinates;
using MGroup.XFEM.CrackGeometry.CrackTip;
using MGroup.XFEM.Utilities;

namespace MGroup.XFEM.Enrichments.Functions
{
    public interface ITipFunction: IEnrichmentFunction2D
    {
        double EvaluateAt(PolarPoint2D point);
        EvaluatedFunction2D EvaluateAllAt(PolarPoint2D point, TipJacobians jacobian);
    }
}
