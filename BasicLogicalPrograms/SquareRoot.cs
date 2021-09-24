using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicalPrograms
{
    class SquareRoot
    {
        public void CalSquareRoot(double c)
        {
            double t = c;
            double l = 0.00001;
            double root;
            int count = 0;
            while (true)
            {
                count++;
                root = 0.5 * (t + (c / t));
                if (Math.Abs(root - t) < l)
                    break;
                t = root;
            }
           Console.WriteLine("The Square Root using Newton Method is "+ root);
        }
    }
}
