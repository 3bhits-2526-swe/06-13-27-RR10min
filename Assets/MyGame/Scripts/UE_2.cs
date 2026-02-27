using System.Globalization;
using UnityEngine;

public class UE_2 : MonoBehaviour
{
    private void Start()
    {
        string text = "56";
        int zahl = int.Parse(text);
        Debug.Log("Zahl: " + zahl);

        string text1 = "7,89";
        // use German culture so ',' is accepted
        if (float.TryParse(text1, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.GetCultureInfo("de-DE"), out float wert))
        {
            Debug.Log("Float-Wert: " + wert);
        }
        else
        {
            Debug.Log("Ungültiger Float-Wert");
        }

        string text3 = "false";
        bool flag = bool.Parse(text3); // returns false — expected
        Debug.Log("Bool-Wert: " + flag);
    }
}