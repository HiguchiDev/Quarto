using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAxis : MonoBehaviour
{
    public Transform m_target;

    public Vector3 touchStartPos;
    public Vector3 touchEndPos;
    public string Direction;
    bool oneplay;


    private void Update()
    {
		//this.rotate(10.0f);
		this.flick();
    }


	private void rotate(float rotateSpeed)
    {
		transform.RotateAround
		(
			m_target.position,
			Vector3.up,
			rotateSpeed / 2
		);
	}

	private void flick()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			touchStartPos = new Vector3(Input.mousePosition.x,
				Input.mousePosition.y,
				Input.mousePosition.z);


		}

		if (Input.GetKey(KeyCode.Mouse0))
		{
			touchEndPos = new Vector3(Input.mousePosition.x,
				Input.mousePosition.y,
				Input.mousePosition.z);
			getDirection();

		}
	}

	private void getDirection()
	{
		float directionX = touchEndPos.x - touchStartPos.x;

		if (0 < directionX)
		{
			//右向きにフリック
			Direction = "right";
			

		}
		else if (0 > directionX)
		{
			//左向きにフリック
			Direction = "left";
			
		}
        else
        {
			Direction = "touch";
		}

		switch (Direction)
		{
			case "up":
				//上フリックされた時の処理
				break;

			case "down":
				//下フリックされた時の処理
				break;

			case "right":
				//右フリックされた時の処理
				this.rotate(directionX);
				touchStartPos = new Vector3(Input.mousePosition.x,
					Input.mousePosition.y,
					Input.mousePosition.z);
				touchEndPos = new Vector3(Input.mousePosition.x,
					Input.mousePosition.y,
					Input.mousePosition.z);
				break;

			case "left":
				//左フリックされた時の処理
				this.rotate(directionX);
				touchStartPos = new Vector3(Input.mousePosition.x,
					Input.mousePosition.y,
					Input.mousePosition.z);

				touchEndPos = new Vector3(Input.mousePosition.x,
					Input.mousePosition.y,
					Input.mousePosition.z);
				break;

			case "touch":
				//タッチされた時の処理
				break;
		}

	}



}
