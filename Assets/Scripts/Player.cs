using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player {
    // w grze standardowo ma sie na poczatku piec pionkow
    public const int maxPawns = 5;
    public int pawnsInHand { get; private set; }
    public Color pawnColor;

    public Player(Color color)
    {
        // nadaj graczowi kolor i daj do ręki 5 pionkow
        this.pawnColor = color;
        this.pawnsInHand = maxPawns;
    }

    public int PutDownPawn()
    {
        /* gracz oddaje pionek z ręki
         * zwraca pozostałą ilość pionków*/
        return --pawnsInHand;
    }

    public int PickUpPawn()
    {
        /* gracz dobiera pionek do ręki
         * zwraca pozostałą ilość pionków*/
        if (pawnsInHand < 5)
        {
            pawnsInHand++;
        }
        return pawnsInHand;
    }

}
