using System.Collections.Generic;
using MGroup.FEM.Interpolation;
using MGroup.MSolve.Geometry.Coordinates;
using MGroup.XFEM.Elements;
using MGroup.XFEM.Entities;
using MGroup.XFEM.FreedomDegrees;
using MGroup.XFEM.Utilities;

namespace MGroup.XFEM.Enrichments.Items
{
    abstract class AbstractEnrichmentItem2D: IEnrichmentItem2D
    {
        protected List<XContinuumElement2D> affectedElements;

        public IReadOnlyList<EnrichedDof> Dofs { get; protected set; }
        public IReadOnlyList<XContinuumElement2D> AffectedElements { get { return affectedElements; } }

        protected AbstractEnrichmentItem2D()
        {
            this.affectedElements = new List<XContinuumElement2D>();
        }

        public void EnrichNode(XNode node) // TODO: this should not be done manually
        {
            double[] enrichmentValues = EvaluateFunctionsAt(node);
            node.EnrichmentItems.Add(this, enrichmentValues);
        }

        //TODO: I tried an alternative approach, ie elements access their enrichments from their nodes. 
        //      My original thought that this approach (storing enrichments in elements, unless they are standard /
        //      blending) wouldn't work for blending elements, was incorrect, as elements with 0 enrichments
        //      were then examined and separated into standard / blending.
        public void EnrichElement(XContinuumElement2D element)
        {
            if (!affectedElements.Contains(element))
            {
                affectedElements.Add(element);
                element.EnrichmentItems.Add(this);
            }
        }

        public abstract double[] EvaluateFunctionsAt(XNode node);
        public abstract EvaluatedFunction2D[] EvaluateAllAt(NaturalPoint point, XContinuumElement2D element,
             EvalInterpolation2D interpolation);

        public abstract IReadOnlyList<CartesianPoint> IntersectionPointsForIntegration(XContinuumElement2D element);
    }
}
