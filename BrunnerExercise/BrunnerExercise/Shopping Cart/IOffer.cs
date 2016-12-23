using BrunnerExercise.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrunnerExercise.Shopping_Cart
{
    public interface IOffer
    {
        //interface for kinds of Offers

        //Apple Offer
        decimal GetTotal_AppleOffer(List<CartItem> cartItem);

        //Orange Offer
        decimal GetTotal_OrangeOffer(List<CartItem> cartItem);

    }
}
