using UnityEngine;
using System.Text.RegularExpressions;

public class MyRegEx : MonoBehaviour
{
    string loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras fermentum 123 orci nec magna porta, sed efficitur arcu faucibus...";

    private void Start()
    {
        bool contains123 = Regex.IsMatch(loremIpsum, "123");
        Debug.Log("Contains '123'? " + contains123);
    }
}
