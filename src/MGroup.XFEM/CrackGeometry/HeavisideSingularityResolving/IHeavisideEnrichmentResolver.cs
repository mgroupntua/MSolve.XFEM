using System.Collections.Generic;
using MGroup.MSolve.Discretization.Mesh;
using MGroup.XFEM.Elements;
using MGroup.XFEM.Entities;

namespace MGroup.XFEM.CrackGeometry.HeavisideSingularityResolving
{
    public interface IHeavisideSingularityResolver
    {
        ISet<XNode> FindHeavisideNodesToRemove(ISingleCrack crack, IMesh2D<XNode, XContinuumElement2D> mesh, 
            ISet<XNode> heavisideNodes);

        ISet<XNode> FindHeavisideNodesToRemove(ISingleCrack crack, IReadOnlyList<XNode> heavisideNodes,
            IReadOnlyList<ISet<XContinuumElement2D>> nodalSupports);
    }
}
