using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KilltextController : MonoBehaviour {
    public Text Killtext;
    int[] kills = new int[5] {0, 1, 2, 3, 4 };
    int killNumber;
    public int i;
	void Start () {
        i = 0;
        
	}
	
	
	void Update () {
        killNumber = kills[i];
        Killtext.text = "Kills " + killNumber.ToString();

	}
}
