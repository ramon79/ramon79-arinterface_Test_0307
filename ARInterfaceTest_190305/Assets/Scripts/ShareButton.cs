﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ShareButton : MonoBehaviour {
	public void ClickShare()
	{
		StartCoroutine(TakeSSAndShare());
		//StartCoroutine(LoadImageAndShare());


	}

	private IEnumerator TakeSSAndShare()
	{
		yield return new WaitForEndOfFrame();

		Texture2D ss = new Texture2D( Screen.width, Screen.height, TextureFormat.RGB24, false );
		ss.ReadPixels( new Rect( 0, 0, Screen.width, Screen.height ), 0, 0 );
		ss.Apply();

		string filePath = Path.Combine( Application.temporaryCachePath, "shared img.png" );
		File.WriteAllBytes( filePath, ss.EncodeToPNG() );
		
		// To avoid memory leaks
		Destroy( ss );

		// new NativeShare().AddFile( filePath ).SetSubject( "MyGames" ).SetText( "I scored 10 points in MyGames." ).Share();
		new NativeShare().AddFile( filePath ).Share();

		// Share on WhatsApp only, if installed (Android only)
		//if( NativeShare.TargetExists( "com.whatsapp" ) )
		//	new NativeShare().AddFile( filePath ).SetText( "Hello world!" ).SetTarget( "com.whatsapp" ).Share();
	}
	private IEnumerator LoadImageAndShare()
	{
		Texture2D image = Resources.Load("image", typeof(Texture2D)) as Texture2D;
		yield return null;
		string filePath = Path.Combine( Application.temporaryCachePath, "shared img.png" );
		File.WriteAllBytes( filePath, image.EncodeToPNG() );

		new NativeShare().AddFile( filePath ).Share();


	}


}
