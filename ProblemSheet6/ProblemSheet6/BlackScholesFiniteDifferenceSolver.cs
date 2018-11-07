using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSheet6
{
    public class BlackScholesFiniteDifferenceSolver
    {
        // ... private member variables of your choice
        // useful constructor
        public BlackScholesFiniteDifferenceSolver(double maturity,
            Func<double, double> payoffFunction,
            double riskFreeRate,
            double sigma,
            double R,
            uint numTimeSteps,
            uint numSpacePartitions)
        {
            // ... constructor code
        }

        // ... some private methods may be useful
        public double Price(double s)
        {
            // ... solve the finite difference approximation
            // and provide the option price if the underlying is S
            // use linear interpolation if S is not one of the grid points
            throw new NotImplementedException();
        }
    }
}