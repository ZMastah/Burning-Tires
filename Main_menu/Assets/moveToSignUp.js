#pragma strict

function Start () {
}

function Update () {
	if (Input.GetButton("Button_signup")){
		//Application.LoadLevel("sign_up");
		Application.OpenURL("http://www.naver.com/");
	}
} // can be called over and over again 
