using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KilltextController : MonoBehaviour {
    public Text Killtext;
    int[] kills = new int[5] {0, 1, 2, 3, 4 }; //array of number of kills
    int killNumber;
    public int i;
	void Start () {
        i = 0;
        
	}
	
	
	void Update () {
        killNumber = kills[i];
        //when enemy is killed, this shows numbers within the kills array
        Killtext.text = "Kills: " + killNumber.ToString();

	}
}
