using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{
    internal class GeomProgression : ISeries
    {
        int startValue;
        int currentvalue;
        int step;
        public int GetNext()
        {
            currentvalue *= step;
            return currentvalue;
        }

        public void Reset()
        {
            currentvalue = startValue;
        }

        public void SetStart(int x)
        {
            startValue = x;
            currentvalue = startValue;
        }
        public void SetStep(int step)
        {
            this.step = step;
        }
    }
}
