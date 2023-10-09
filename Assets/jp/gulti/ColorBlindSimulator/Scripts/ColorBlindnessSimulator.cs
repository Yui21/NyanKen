using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace jp.gulti.ColorBlind
{

	public class ColorBlindnessSimulator : jp.gulti.PostEffectsBase
	{
		public enum ColorBlindMode
		{
			Protanope,
			Deuteranope,
		}
		[SerializeField]
		public ColorBlindMode BlindMode = ColorBlindMode.Protanope;

		[SerializeField]
		public float BlindIntensity = 1.0f;

		[SerializeField]
		public Shader ColorBlindShader;
		private Material ColorBlindMat;

		public static readonly string ColorBlindShaderName = "Hidden/GULTI/ColorBlindSimulator";

		#region Overrides
		
		protected override bool CheckResources ()
		{
			CheckSupport(false);
			ColorBlindShader = Shader.Find(ColorBlindShaderName);
			ColorBlindMat = CreateMaterial(ColorBlindShader, ColorBlindMat);
			return ColorBlindMat != null;
		}
		
		#endregion

		#region Monobehavior

		void OnDisable()
		{
			if(ColorBlindMat != null)
			{
#if UNITY_EDITOR
				if(!UnityEditor.EditorApplication.isPlaying)
					DestroyImmediate(ColorBlindMat, true);
				else
#endif
				Destroy(ColorBlindMat);
			}
		}

		void OnRenderImage(RenderTexture _src, RenderTexture _dst)
		{
			if(ColorBlindMat == null)
			{
				if(!CheckResources())
				{
					NotSupported();
					return;
				}
			}

			switch (BlindMode)
			{
				case ColorBlindMode.Protanope:
					ColorBlindMat.shaderKeywords = new string[] { "CB_TYPE_ONE" };
					break;
				case ColorBlindMode.Deuteranope:
					ColorBlindMat.shaderKeywords = new string[] { "CB_TYPE_TWO" };
					break;
			}

			//Intensity Set
			ColorBlindMat.SetFloat("_BlindIntensity", BlindIntensity);

			Graphics.Blit(_src, _dst, ColorBlindMat);
		}

		#endregion
	}
}