﻿using Independence;

namespace DreamLifter
{
    /// <summary>
    /// Insist that the class implements linear solver for matrices.
    /// </summary>
    public interface ILinearSolver
    {
        /// <summary>
        /// Set a matrix to this solver (shallow copy)
        /// </summary>
        void SetMatrix(DoubleSparseMatrix matrix);

        /// <summary>
        /// Solve a linear equation of the form [A \cdot x = (rhs)] for x.
        /// </summary>
        /// <returns></returns>
        DoubleDenseMatrix Solve(DoubleDenseMatrix rhs);
    }
}
