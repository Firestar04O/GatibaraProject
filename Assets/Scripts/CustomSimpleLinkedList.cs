using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomSimpleLinkedList<T> : SimpleLinkedList<T>
{
    Player player;
    int count2 = 0;
    public void AddElement(T value)
    {
        if (count2 < player.spellnumber)
        {
            Add(value);
            count2++;
        }
        else
        {
            Remove(head.Value);
            Add(value);
        }
    }
}
