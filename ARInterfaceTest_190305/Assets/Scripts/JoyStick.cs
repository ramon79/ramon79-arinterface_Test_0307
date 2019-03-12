using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoyStick : MonoBehaviour {
	public WheelCollider wheelFL;
	public WheelCollider wheelFR;
	public WheelCollider wheelRL;
	public WheelCollider wheelRR;
	public Transform wheelFLTransform;
	public Transform wheelFRTransform;
	public Transform wheelRLTransform;
	public Transform wheelRRTransform;

	// Use this for initialization

	public GameObject sportscar;

	public Transform car;
	public Transform Stick;
	private Vector3 StickFirstPos;
	private Vector3 JoyVec;
	private float Radius;
	private bool MoveFlag;
	
	void Start () {
		Radius = GetComponent<RectTransform>().sizeDelta.y * 0.5f;
		StickFirstPos = Stick.transform.position;

		float Can = transform.parent.GetComponent<RectTransform>().localScale.x;
		Radius*= Can;

		MoveFlag = false;
	}

	void Update () {
		if (MoveFlag)
			car.transform.Translate(Vector3.forward*Time.deltaTime*5f);

			//휠 회전 효과
			wheelFLTransform.Rotate(wheelFL.rpm / 60 * 360 *Time.deltaTime, 0.0f, 0.0f);
			wheelFLTransform.Rotate(wheelFR.rpm / 60 * 360 *Time.deltaTime, 0.0f, 0.0f);
			wheelFLTransform.Rotate(wheelRL.rpm / 60 * 360 *Time.deltaTime, 0.0f, 0.0f);
			wheelFLTransform.Rotate(wheelRR.rpm / 60 * 360 *Time.deltaTime, 0.0f, 0.0f);
	}

	public void Drag(BaseEventData _Data) {
		MoveFlag = true;
		PointerEventData data = _Data as PointerEventData;
		Vector3 Pos = data.position;

		JoyVec = (Pos - StickFirstPos).normalized;
		float Dis = Vector3.Distance(Pos,StickFirstPos);
		if (Dis < Radius)
            Stick.position = StickFirstPos + JoyVec * Dis;
        // 거리가 반지름보다 커지면 조이스틱을 반지름의 크기만큼만 이동.
        else
            Stick.position = StickFirstPos + JoyVec * Radius;


		car.eulerAngles = new Vector3(0,Mathf.Atan2(JoyVec.x,JoyVec.y)*Mathf.Rad2Deg,0);
    }
 
    // 드래그 끝.
    public void DragEnd()
    {
        Stick.position = StickFirstPos; // 스틱을 원래의 위치로.
        JoyVec = Vector3.zero;          // 방향을 0으로.
		MoveFlag = false;
    }

	public void OriginalPosition()
	{
		sportscar.transform.position = new Vector3(0,0,30);
	} 
}
 
	


	// Update is called once per frame


