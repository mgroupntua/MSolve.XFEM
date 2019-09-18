using System.Collections.Generic;
using MGroup.LinearAlgebra.Vectors;
using MGroup.MSolve.Geometry.Coordinates;
using MGroup.XFEM.CrackGeometry.CrackTip;
using MGroup.XFEM.Elements;

namespace MGroup.XFEM.CrackPropagation
{
    public interface IPropagator
    {
        PropagationLogger Logger { get; }

        (double growthAngle, double growthLength) Propagate(Dictionary<int, Vector> totalFreeDisplacements, CartesianPoint crackTip, 
            TipCoordinateSystem tipSystem, IReadOnlyList<XContinuumElement2D> tipElements);
    }
}
