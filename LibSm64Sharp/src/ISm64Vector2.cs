using System.Numerics;


namespace libsm64sharp {
  public interface IReadOnlySm64Vector2<TNumber>
       {
    TNumber X { get; }
    TNumber Y { get; }
  }

  public interface ISm64Vector2<TNumber> : IReadOnlySm64Vector2<TNumber>
       {
    new TNumber X { get; set; }
    new TNumber Y { get; set; }
  }
}