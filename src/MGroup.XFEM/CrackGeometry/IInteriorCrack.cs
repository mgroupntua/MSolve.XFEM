using MGroup.MSolve.Geometry.Coordinates;
using MGroup.XFEM.Enrichments.Items;

namespace MGroup.XFEM.CrackGeometry
{
    interface IInteriorCrack: ISingleCrack
    {
        CrackTipEnrichments2D StartTipEnrichments { get; }
        CrackTipEnrichments2D EndTipEnrichments { get; }

        void InitializeGeometry(CartesianPoint startTip, CartesianPoint endTip);

        //TODO: remove it. It is obsolete and should be handled by ICrackGeometry.Propagate()
        void UpdateGeometry(double localGrowthAngleStart, double growthLengthStart,
            double localGrowthAngleEnd, double growthLengthEnd); // Perhaps the global angle should be passed in
    }
}
