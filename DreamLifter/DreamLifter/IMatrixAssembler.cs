﻿using Independence;
using System;

namespace DreamLifter
{
    /// <summary>
    /// Insist that this class can generate some matrices.
    /// </summary>
    public interface IMatrixAssembler
    {
        /// <summary>
        /// Acquire the differential matrix.
        /// </summary>
        /// <param name="axis">Specify the differential direction.</param>
        /// <returns></returns>
        DoubleSparseMatrix GetDifferentialMatrix(Axis axis);

        /// <summary>
        /// Acquire the mass matrix of the system.
        /// </summary>
        /// <remarks>
        /// This method can have heavy computational cost. 
        /// </remarks>
        DoubleSparseMatrix GetMassMatrix();

        /// <summary>
        /// Acquire the stiffness matrix.
        /// </summary>
        /// <param name="diffusivity">Set the diffusivity vector.</param>
        /// <returns></returns>
        DoubleSparseMatrix GetStiffnessMatrix(DoubleDenseMatrix diffusivity);

        DoubleSparseMatrix GetAdvectionMatrix(Func<DoubleDenseMatrix, Axis> velocityHandler);
    }
}
