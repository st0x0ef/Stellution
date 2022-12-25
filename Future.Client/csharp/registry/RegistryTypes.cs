using System.Collections.Generic;
using Future.Client.csharp.renderer;
using Future.Client.csharp.ticker;
using Microsoft.Xna.Framework.Graphics;

namespace Future.Client.csharp.registry; 

public class RegistryTypes {

    public static readonly Dictionary<string, DefaultRenderer> Renderers = new();
    public static readonly Dictionary<string, SpriteFont> Fonts = new();
    public static readonly Dictionary<string, ClientTicker> Ticker = new();
}