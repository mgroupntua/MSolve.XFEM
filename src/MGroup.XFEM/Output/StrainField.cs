﻿using MGroup.FEM.Interpolation;
using MGroup.LinearAlgebra.Matrices;
using MGroup.LinearAlgebra.Vectors;
using MGroup.MSolve.Discretization.Commons;
using MGroup.MSolve.Geometry.Coordinates;
using MGroup.XFEM.Elements;

namespace MGroup.XFEM.Output
{
    //TODO: Would be better to do it with deformation matrices, but requires unification of vectors and matrices
    class StrainField : IOutputField
    {
        public Tensor2D EvaluateAt(XContinuumElement2D element, NaturalPoint point,
            Vector standardDisplacements, Vector enrichedDisplacements)
        {
            EvalInterpolation2D evaluatedInterpolation = element.Interpolation.EvaluateAllAt(element.Nodes, point);
            Matrix2by2 displacementGradient = element.CalculateDisplacementFieldGradient(
                point, evaluatedInterpolation, standardDisplacements, enrichedDisplacements);

            double strainXX = displacementGradient[0, 0];
            double strainYY = displacementGradient[1, 1];
            double strainXY = 0.5 * (displacementGradient[0, 1] + displacementGradient[1, 0]);

            return new Tensor2D(strainXX, strainYY, strainXY);
        }
    }
}
