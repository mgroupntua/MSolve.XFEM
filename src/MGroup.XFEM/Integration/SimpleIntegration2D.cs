using System.Collections.Generic;
using MGroup.MSolve.Discretization.Integration;
using MGroup.XFEM.Elements;

namespace MGroup.XFEM.Integration
{
    public class SimpleIntegration2D : IIntegrationStrategy2D<XContinuumElement2D>
    {
        public SimpleIntegration2D()
        {
        }

        public IReadOnlyList<GaussPoint> GenerateIntegrationPoints(XContinuumElement2D element)
        {
            return element.StandardQuadrature.IntegrationPoints;
        }
    }
}
