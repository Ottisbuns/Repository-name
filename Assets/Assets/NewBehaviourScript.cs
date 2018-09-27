using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public string sentence1;
    public string sentence2;
    public string sentence3;
    public int number;
    public int bas;
    public int vinkel;
    public int bitar;
    public string namn;
    public int radius;
    public int damage;
    public int life;
    public int demons;
    public int maxdamage;
    public int mindamage;
	// Use this for initialization
	void Start () {

        TestFunktion();
        Uppgift2();
        Uppgift3();
        Uppgift4();
        Uppgift1();
        Uppgift5();
        Uppgift5a();
        Uppgift6();
        Uppgift8();
        Uppgift8a();
        Uppgift8b();
        Uppgift8c();
	}

    void Uppgift2()
    {
        Sentence1();
        Sentence2();
        Sentence3();
    }

    void Sentence1()
    {
        Debug.Log(sentence1);
    }
    void Sentence2()
    {
        Debug.Log(sentence2);
    }
    void Sentence3()
    {
        Debug.Log(sentence3);
    }
    void TestFunktion()
    {
        Debug.Log("Detta är min TestFunktion()");
    }

    void Uppgift1()
    {
        Debug.Log(string.Format("Svaret på (963 * 421) - (175463 / 87) är {0}", (963 * 421) - (175463 / 87)));
    }

    void Uppgift3()
    {
        Debug.Log(string.Format("Talet {0} upphöjt med 2 blir {1} och kvadratroten ur {0} är {2}", number, Mathf.Pow(number, 2), Mathf.Sqrt(number)));
    }
    
    void Uppgift4()
    {
        Debug.Log(string.Format("Arean på en triangel med höjden 8 och basen {0} är {1}m^2", bas, bas * 8 / 2));
    }

    void Uppgift5()
    {
        Debug.Log(string.Format("Med vinkel {0} så får man {1} bitar", vinkel, 360f / vinkel));
    }

    void Uppgift5a()
    {
        Debug.Log(string.Format("Om man har {0} bitar så har dom en vinkel av {1}", bitar, 360f / bitar));
    }

    void Uppgift6()
    {
        Debug.Log(string.Format("Overlord {0}, Herald of Annihilation", namn));
    }
    
    //void Uppgift7()
    //{
    //    Debug.Log(string.Format("Med en radius av {0} så har 2978 klot en volym av {1}",));
    //}

    void Uppgift8()
    {
        Debug.Log(string.Format("Det skulle ta {1} attacker med {0} skada för att döda Overlord {2}, herald of Annihilation", damage, 1000000000000 / damage, namn));
    }

    void Uppgift8a()
    {
        Debug.Log(string.Format("Det skulle ta {1} attacker med {0} skada för att döda Overlord {2}, herald of Annihilation", damage, life / damage, namn));
    }

    void Uppgift8b()
    {
        Debug.Log(string.Format("Det skulle ta {1} attacker med {0} skada för att döda {2} Overlord {3}, Herald of Annihilation", damage, (1000000000000 / damage) * demons, demons, namn));
    }

    void Uppgift8c()
    {
        Debug.Log(string.Format("Det skulle ta mellan {1} och {2} attacker med {0} till {3} skada för att döda Overlord {4}, Herald of Annihilation", maxdamage, 1000000000000 / maxdamage, 1000000000000 / mindamage, mindamage, namn));
    }


    // Update is called once per frame
    void Update () {
		
	}
}
