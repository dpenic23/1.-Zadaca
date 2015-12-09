using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pong {

    /// <summary>
    /// Provides method used for checking if two Sprite objects are overlapping.
    /// Both objects dimensions are represented with rectangles so this method
    /// returns true if two rectangles overlap in coordinate system.
    /// </summary>
    public class CollisionDetector {

        /// <summary>
        /// Calculates if rectangles describing two sprites are
        /// overlapping on screen.
        /// </summary>
        /// <param name="s1">First sprite</param>
        /// <param name="s2">Second sprite</param>
        /// <returns>Returns true if overlapping, false otherwise.</returns>
        public static bool Overlaps(Sprite s1, Sprite s2) {
            // Check if they overlap over X axis
            if(!OverlapsOverSingleAxis(s1.Position.X, s1.Position.X + s1.Size.Width,
                s2.Position.X, s2.Position.X + s2.Size.Width)) {
                return false;
            }

            // Check if they overlap over Y axis
            if (!OverlapsOverSingleAxis(s1.Position.Y, s1.Position.Y + s1.Size.Height,
                s2.Position.Y, s2.Position.Y + s2.Size.Height)) {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks if two intervals overlap.
        /// </summary>
        /// <param name="firstStart">Start point of first interval.</param>
        /// <param name="firstEnd">End point of first interval.</param>
        /// <param name="secondStart">Start point of second interval.</param>
        /// <param name="secondEnd">End point of second interval.</param>
        /// <returns></returns>
        private static bool OverlapsOverSingleAxis(float firstStart, float firstEnd, 
            float secondStart, float secondEnd) {
            if(firstStart > secondEnd || firstEnd < secondStart) {
                return false;
            }

            return true;
        }
    }
}
