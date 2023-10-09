using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace jp.gulti
{

//C# fork  PostEffectsBase.js
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public abstract class PostEffectsBase : MonoBehaviour
	{
	#region Abstracts
	
		/// <summary>
		///  override to check needed resources to postprocess.
		/// </summary>
		/// <returns>
		/// Availability
		/// </returns>
		protected abstract bool CheckResources ();
	
	#endregion
	
	#region static
	
		public static bool SupportHDRTextures {
			get {
				if (_SupportHDRTextures == 2) {
					_SupportHDRTextures = SystemInfo.SupportsRenderTextureFormat (RenderTextureFormat.ARGBHalf)
					? 1 : 0;
				}
				return _SupportHDRTextures == 1;
			}
		}

		private static int _SupportHDRTextures = 2;
	
	#endregion
	
		protected bool isSupported = true;
	
		void Start ()
		{
			CheckResources ();
		}

		void OnEnable ()
		{
			isSupported = true;
			CheckResources ();
		}
	
		protected Material CreateMaterial (Shader s, Material m2Create)
		{
			if (s == null) 
			{
				return null;
			}

			if ((m2Create != null) && (m2Create.shader == s) && (s.isSupported))
			{
				return m2Create;
			}
		
			if (!s.isSupported)
			{
				return null;
			}
			else
			{
				m2Create = new Material (s);	
				m2Create.hideFlags = HideFlags.DontSave;

				if (m2Create != null)
				{
					return m2Create;
				}
				else
				{
					return null;
				}
			}
		}
	
		protected void NotSupported ()
		{
			enabled = false;
			isSupported = false;
			return;
		}
	
		protected void ReportAutoDisable ()
		{
			Debug.LogWarning ("The image effect " + this.ToString () + " has been disabled as it's not supported on the current platform.");
		}
	
		protected bool CheckSupport (bool needDepth)
		{
			isSupported = true;
		
			if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures) {
				NotSupported ();
				return false;
			}		
		
			if (needDepth && !SystemInfo.SupportsRenderTextureFormat (RenderTextureFormat.Depth)) {
				NotSupported ();
				return false;
			}
		
			if (needDepth)
				GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;	
		
			return true;
		}

		protected bool CheckSupport (bool needDepth, bool needHdr)
		{
			if (!CheckSupport (needDepth))
				return false;
		
			if (needHdr && !SupportHDRTextures) {
				NotSupported ();
				return false;		
			}
		
			return true;
		}	
	
	}

}
