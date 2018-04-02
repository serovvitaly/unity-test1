using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstMenu : MonoBehaviour
{

	public Button buttonCompany;
	public Button buttonCancel;
	
	// Use this for initialization
	void Start ()
	{
		Button btnCompany = buttonCompany.GetComponent<Button>();
		btnCompany.onClick.AddListener(BtnCompanyOnClick);
		
		Button btnCancel = buttonCancel.GetComponent<Button>();
		btnCancel.onClick.AddListener(BtnCancelOnClick);
	}

	void BtnCompanyOnClick()
	{
		Debug.Log("Нажата кнопка `Компания`");
	}

	void BtnCancelOnClick()
	{
		Debug.Log("Нажата кнопка `Покинуть игру`");
		Application.Quit();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
