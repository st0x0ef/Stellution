using Easel.Graphics.Renderers;
using Easel.GUI;
using Easel.Math;
using Stellution.Client.csharp.registry.types;

namespace Stellution.Client.csharp.overlay.types; 

public class CrosshairOverlay : Overlay {

    public override void Draw(SpriteRenderer renderer) {
        this.DrawImage(TextureRegistry.Crosshair.Value, new Position(Anchor.CenterCenter), new Size<int>(24));
    }
}