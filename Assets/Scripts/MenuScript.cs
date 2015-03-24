using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class MenuScript : MonoBehaviour {

	public Image SelectionText;
	public List<Sprite> ItemList = new List<Sprite>();
	private int itemSpot = 0;

	void Start(){ }

	void Update()
	{
		Debug.Log ("spot: "+itemSpot);
	}


	public void RightSelection()
	{
		GameObject.Find("toggle_music").SendMessage("playSound");
		if(itemSpot < 1){ itemSpot = 3; }
		itemSpot-=1;
		SelectionText.sprite = ItemList[itemSpot];

	}

	public void LeftSelection()
	{
		GameObject.Find("toggle_music").SendMessage("playSound");
		if(itemSpot > 1){ itemSpot = -1; }
		itemSpot+=1;
		SelectionText.sprite = ItemList [itemSpot];
	
	}

	public void StartSelection()
	{
		if(itemSpot == 0)
		{
			GameObject.Find("correct_audio").SendMessage("playSound");
			Application.LoadLevel ("a1");
		}
		else if(itemSpot == 1)
		{
			GameObject.Find("incorrect_audio").SendMessage("playSound");
			//Application.LoadLevel ("");
		}
		else if(itemSpot == 2)
		{
			GameObject.Find("incorrect_audio").SendMessage("playSound");
			//Application.LoadLevel ("");
		}
	}
}
