using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Generator : MonoBehaviour {
	public FetishDB fetishes;
	public Text fetText;

	string noun;
	string verb;
	string flavor;

	int nIndex;
	int vIndex;
	int fIndex;
	// Use this for initialization
	void Start () {


		//GenerateFetish(noun, verb, flavor);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void GenerateFetish(){
		//Debug.Log(v + " " + n + " " + f);
		noun = fetishes.nouns[Random.Range(0, fetishes.nouns.Count)];
		verb = fetishes.verbs[Random.Range(0, fetishes.verbs.Count)];
		flavor = fetishes.flavor[Random.Range(0, fetishes.flavor.Count)];

		fetText.text = verb + " " + noun + " " + flavor;
	}
}
