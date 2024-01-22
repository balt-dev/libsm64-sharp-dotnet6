using System.Numerics;


namespace libsm64sharp {
  public partial class Sm64Context {
    private class Sm64Vector2<TNumber> : ISm64Vector2<TNumber>
         {
      public TNumber X { get; set; }
      public TNumber Y { get; set; }
    }
  }
}