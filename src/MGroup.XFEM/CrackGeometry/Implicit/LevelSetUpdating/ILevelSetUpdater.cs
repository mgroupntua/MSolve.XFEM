using System.Collections.Generic;
using MGroup.MSolve.Geometry.Coordinates;
using MGroup.XFEM.Entities;

//TODO: should it just pull properties out of the LSM rather than all these parameters? It would be much more abstracted.
//TODO: this strategy interface should probably handle all geometry updates, not only the level sets.
namespace MGroup.XFEM.CrackGeometry.Implicit.LevelSetUpdating
{
    interface ILevelSetUpdater
    {
        /// <summary>
        /// Returns nodes that were previously enriched with Heaviside and now their body level set changes.
        /// </summary>
        /// <returns></returns>
        HashSet<XNode> Update(CartesianPoint oldTip, double localGrowthAngle, double growthLength, double dx, double dy,
            IReadOnlyList<XNode> allNodes, ISet<XNode> crackBodyNodesAll, 
            Dictionary<XNode, double> levelSetsBody, Dictionary<XNode, double> levelSetsTip);
    }
}
