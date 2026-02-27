using NUnit.Framework.Internal;
using Unity.VisualScripting;
using UnityEngine;

public class UE_1 : MonoBehaviour
{
    
    private void Start()
    {
        int u1 = int.Parse("157");
        int u2;
        int.TryParse("123f", out u2);
        Debug.Log(u1);
    }

}
