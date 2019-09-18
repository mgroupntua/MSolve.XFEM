﻿using System.Collections.Generic;
using MGroup.FEM.Interpolation;
using MGroup.MSolve.Geometry.Coordinates;
using MGroup.XFEM.Elements;
using MGroup.XFEM.Entities;
using MGroup.XFEM.FreedomDegrees;
using MGroup.XFEM.Utilities;

namespace MGroup.XFEM.Enrichments.Items
{
    // Connects the geometry, model and enrichment function entities.
    // TODO: At this point it does most of the work in 1 class. Appropriate decomposition is needed.
    public interface IEnrichmentItem2D
    {
        // Perhaps the nodal dof types should be decided by the element type (structural, continuum) in combination with the EnrichmentItem2D and drawn from XContinuumElement2D
        /// <summary>
        /// The order is enrichment function major, axis minor. 
        /// </summary>
        IReadOnlyList<EnrichedDof> Dofs { get; } 

        //IReadOnlyList<XContinuumElement2D> AffectedElements { get; }

        ///// <summary>
        ///// Assigns enrichment functions and their nodal values to each enriched node.
        ///// </summary>
        //void EnrichNodes();

        //void EnrichElement(XContinuumElement2D element);

        IReadOnlyList<CartesianPoint> IntersectionPointsForIntegration(XContinuumElement2D element);

        double[] EvaluateFunctionsAt(XNode node);

        EvaluatedFunction2D[] EvaluateAllAt(NaturalPoint point, XContinuumElement2D element,
             EvalInterpolation2D interpolation);
    }
}
