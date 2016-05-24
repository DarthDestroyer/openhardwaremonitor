using System;
using System.Collections.Generic;
using System.Text;

namespace OpenHardwareMonitor
{
    /// <summary>
    /// A temporary class to fix the missing Bitmask class. (presumably in MultiValue.cs)
    /// </summary>
    class Bitmask
    {
        /// <summary>
        /// Assumed functionality: extract bits and normalize.
        /// </summary>
        /// <param name="eax"></param>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        internal static uint GetValue(uint bits, int v1, int v2)
        {
            int direction = v1 < v2 ? 1 : -1;
            int i = v1;
            uint result = 0;
            int position = 0;
            while (i != v2 && i < 32 && i >= 0)
            {
                result += ((bits >> i) & 1) << position;
                position++;
                i += direction;
            }

            return result;
        }
    }
}