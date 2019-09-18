using MGroup.LinearAlgebra.Vectors;
using MGroup.MSolve.Discretization.Commons;
using MGroup.MSolve.Geometry.Coordinates;
using MGroup.XFEM.Elements;

namespace MGroup.XFEM.Output
{
    interface IOutputField
    {
        Tensor2D EvaluateAt(XContinuumElement2D element, NaturalPoint point,
            Vector standardDisplacements, Vector enrichedDisplacements);
    }
}
