using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSlave : MonoBehaviour {
	public CameraController cameraController;

	void OnPreRender()
	{
		cameraController.SetEye (1);
	}			
}
