//https://www.youtube.com/watch?v=Yp8uPxEn6Vg&ab_channel=CodingwithCarlos

using UnityEngine;
using UnityEngine.Networking;
using System.Threading.Tasks;
using System;

public class apiController : MonoBehaviour
{
	[ContextMenu("Test Get")]
	public async void testGet() {
		var url = "https://jsonplaceholder.typicode.com/todos/1";

		using var www = UnityWebRequest.Get(url);
		www.SetRequestHeader("Content-Type", "application/json");
		var operation = www.SendWebRequest();
		while(!operation.isDone) 
			await Task.Yield();

		var jsonResponse = www.downloadHandler.text;

		if (www.result != UnityWebRequest.Result.Success)
			Debug.Log($"Success: {www.error}");
			
		try {
			//var result = jsonConvert.
			Debug.Log($"Success: {www.downloadHandler.text}");
		} catch (Exception ex) {
			Debug.LogError($"{this} Could not parse {jsonResponse}");
		}
			
	}
}
