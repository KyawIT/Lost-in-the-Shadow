using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
	[SerializeField]
	public GameObject button;

	void Start()
	{
		gameObject.GetComponent<Button>().;
		//btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		Debug.Log("You have clicked the button!");
		
	}
}
