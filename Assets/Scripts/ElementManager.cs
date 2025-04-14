using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class ElementManager : MonoBehaviour
{
    [SerializeField] public CustomSimpleLinkedList<Elements> Elements = new CustomSimpleLinkedList<Elements>();
    [Button]
    public void InvokeSpell()
    {

    }
    [Button]
    public void AddElement(Elements element)
    {
        Elements.AddElement(element);
    }
}
