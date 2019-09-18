using System.Text;
using MGroup.MSolve.Discretization.FreedomDegrees;
using MGroup.XFEM.Enrichments.Functions;

namespace MGroup.XFEM.FreedomDegrees
{
    public class EnrichedDof: IDofType
    {
        public IEnrichmentFunction2D Enrichment { get; }
        public IDofType StandardDof { get; }

        public EnrichedDof(IEnrichmentFunction2D enrichment, IDofType standardDof)
        {
            this.Enrichment = enrichment;
            this.StandardDof = standardDof;
        }
        
        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append(Enrichment.ToString());
            builder.Append(" enriched ");
            builder.Append(StandardDof);
            return builder.ToString();
        }
    }
}
