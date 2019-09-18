using MGroup.FEM.Interpolation;
using MGroup.LinearAlgebra.Matrices;
using MGroup.LinearAlgebra.Vectors;
using MGroup.MSolve.Discretization.Commons;
using MGroup.MSolve.Geometry.Coordinates;
using MGroup.XFEM.Elements;

namespace MGroup.XFEM.Output
{
    class StressField: IOutputField
    {
        public Tensor2D EvaluateAt(XContinuumElement2D element, NaturalPoint point,
            Vector standardDisplacements, Vector enrichedDisplacements)
        {
            EvalInterpolation2D evaluatedInterpolation = element.Interpolation.EvaluateAllAt(element.Nodes, point);
            Matrix2by2 displacementGradient = element.CalculateDisplacementFieldGradient(
                point, evaluatedInterpolation, standardDisplacements, enrichedDisplacements);
            Matrix constitutive =
                element.Material.CalculateConstitutiveMatrixAt(point, evaluatedInterpolation);

            return element.CalculateStressTensor(displacementGradient, constitutive);
        }
    }
}
