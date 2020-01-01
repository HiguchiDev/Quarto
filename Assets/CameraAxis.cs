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
		this.rotate(10.0f);
		//this.flick();
    }


	private void rotate(float rotateSpeed)
    {
		transform.RotateAround
		(
			m_target.position,
			Vector3.up,
			rotateSpeed * Time.deltaTime
		);
	}

	private void flick()
	{
		if (Input.GetKey(KeyCode.Mouse0))
		{
			touchStartPos = new Vector3(Input.mousePosition.x,
				Input.mousePosition.y,
				Input.mousePosition.z);

			touchEndPos = new Vector3(Input.mousePosition.x,
	Input.mousePosition.y,
	Input.mousePosition.z);
			getDirection();
		}

		if (Input.GetKeyUp(KeyCode.Mouse0))
		{

		}
	}

	private void getDirection()
	{
		float directionX = touchEndPos.x - touchStartPos.x;
		float directionY = touchEndPos.y - touchStartPos.y;
		//xがｙより絶対値が大きい時。
		if (Mathf.Abs(directionY) < Mathf.Abs(directionX))
		{
			if (30 < directionX)
			{
				//右向きにフリック
				Direction = "right";

			}
			if (-30 > directionX)
			{
				//左向きにフリック
				Direction = "left";
			}
			//yがxより絶対値が大きい時。
		}
		else if (Mathf.Abs(directionX) < Mathf.Abs(directionY))
		{
			if (30 < directionY)
			{
				//上向きにフリック
				Direction = "up";
			}
			if (-30 > directionY)
			{
				//下向きのフリック
				Direction = "down";
			}
		}
		else
		{
			//タッチを検出
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
				break;

			case "left":
				//左フリックされた時の処理
				this.rotate(directionX);
				break;

			case "touch":
				//タッチされた時の処理
				break;
		}

	}



}
