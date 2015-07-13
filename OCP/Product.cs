using System;

namespace BreakingOpenClosedPrinciple
{
    public abstract class Product
    {
        public abstract void Render();

        public string[] GetImageFileNames()
        {
            return new[] { "image1.jpg", "image2.jpg" };
        }
    }

    #region What's wrong with the above?
// if we add a new ProductType, then we need to modify how this existing code works in order 
// to include the new ProductType.
// What if we add lots more ProductTypes? – We need more and more If statements.
// What if this is not the only thing that varies by ProductType? - We start to duplicate this If block all over our code base.
//
// NB: Don’t fool yourself into thinking that a switch statement is any better – it’s just as bad!
    #endregion 
}
