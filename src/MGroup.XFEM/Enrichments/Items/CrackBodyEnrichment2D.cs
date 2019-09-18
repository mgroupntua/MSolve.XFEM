using System;
using System.Collections.Generic;
using MGroup.FEM.Interpolation;
using MGroup.MSolve.Discretization.FreedomDegrees;
using MGroup.MSolve.Geometry.Coordinates;
using MGroup.XFEM.CrackGeometry;
using MGroup.XFEM.Elements;
using MGroup.XFEM.Enrichments.Functions;
using MGroup.XFEM.Entities;
using MGroup.XFEM.FreedomDegrees;
using MGroup.XFEM.Utilities;

// TODO: this class should not be associated with the whole crack geometry, just the part that stores a single branch.
namespace MGroup.XFEM.Enrichments.Items
{
    public class CrackBodyEnrichment2D : IEnrichmentItem2D
    {
        private readonly IHeavisideFunction2D enrichmentFunction;
        public IReadOnlyList<EnrichedDof> Dofs { get; }
        public ISingleCrack crackDescription;

        public CrackBodyEnrichment2D(ISingleCrack crackDescription): this(crackDescription, new SignFunction2D())
        {
        }

        public CrackBodyEnrichment2D(ISingleCrack crackDescription, IHeavisideFunction2D enrichmentFunction)
        {
            this.crackDescription = crackDescription;
            this.enrichmentFunction = enrichmentFunction;
            this.Dofs = new EnrichedDof[] {
                new EnrichedDof(enrichmentFunction, StructuralDof.TranslationX),
                new EnrichedDof(enrichmentFunction, StructuralDof.TranslationY)
            };
        }
        
        public double[] EvaluateFunctionsAt(XNode node)
        {
            double signedDistance = crackDescription.SignedDistanceOf(node);
            return new double[] { enrichmentFunction.EvaluateAt(signedDistance) };
        }

        public EvaluatedFunction2D[] EvaluateAllAt(NaturalPoint point, XContinuumElement2D element,
             EvalInterpolation2D interpolation)
        {
            CartesianPoint cartesianPoint = interpolation.TransformPointNaturalToGlobalCartesian();
            double signedDistance = crackDescription.SignedDistanceOf(point, element, interpolation);
            return new EvaluatedFunction2D[] { enrichmentFunction.EvaluateAllAt(signedDistance) };
        }


        // TODO: delete this
        public IReadOnlyList<CartesianPoint> IntersectionPointsForIntegration(XContinuumElement2D element)
        {
            throw new NotImplementedException();
        }
    }
}
