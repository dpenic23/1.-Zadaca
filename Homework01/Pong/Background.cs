using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pong {

    /// <summary>
    /// Represents Sprite object which holds background image of this
    /// game.
    /// </summary>
    public class Background : Sprite {

        /// <summary>
        /// Creates new Background object with specified parameters.
        /// </summary>
        /// <param name="spriteTexture">Sprite texture for this background.</param>
        /// <param name="width">Background width.</param>
        /// <param name="height">Background height.</param>
        public Background(Texture2D spriteTexture, int width, int height)
            : base(spriteTexture, width, height) {
        }
    }
}
