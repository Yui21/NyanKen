Shader "Hidden/GULTI/ColorBlindSimulator"
{
	Properties
	{
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_BlindIntensity ("Color-Blind Intensity", Range(0,1)) = 1
	}
	
	SubShader
	{
		Pass
		{
			CGPROGRAM
#include "UnityCG.cginc"
#include "ColorBlindInc.cginc"

#pragma multi_compile CB_TYPE_ONE CB_TYPE_TWO
#pragma target 3.0
#pragma vertex vert_img
#pragma fragment frag
#pragma fragmentoption ARB_precision_hint_fastest
			
			uniform sampler2D _MainTex;
			uniform fixed _BlindIntensity;
			float4 _MainTex_TexelSize;
			
			fixed4 frag(v2f_img i) : COLOR
			{
				// Direct3D9 needs texel offset
				float2 uv = i.uv;
#ifdef UNITY_HALF_TEXEL_OFFSET
				uv.y += _MainTex_TexelSize.y;
#endif
				//Original Color
				fixed4 origColor = tex2D(_MainTex, uv);
				
				//Convert RGB to LMS
				fixed3 tmp1;
				fixed3 tmp2;
				
				tmp1 = IjkToRgb1(origColor.rgb);
				
#if CB_TYPE_ONE
				tmp2 = Rgb1ToRgb2_Type1(tmp1);
#else
				tmp2 = Rgb1ToRgb2_Type2(tmp1);
#endif

				tmp1 = Rgb2ToXyz(tmp2);
				tmp2 = XyzToLms(tmp1);
				
				//Simulate Color Blind:
#if CB_TYPE_ONE
				//Color Blind Type I(Protanope)
				tmp1 = LmsColorBlindType1(tmp2, _BlindIntensity);
#else
				//Color Blind Type II(Deuteranope)
				tmp1 = LmsColorBlindType2(tmp2, _BlindIntensity);
#endif

				//Revert to RGB
				tmp2 = LmsToXyz(tmp1);
				tmp1 = XyzToRgb2(tmp2);
#if CB_TYPE_ONE
				tmp2 = Rgb2ToRgb1_Type1(tmp1);
#else
				tmp2 = Rgb2ToRgb1_Type2(tmp1);
#endif
				fixed4 retColor;
				retColor.rgb = Rgb2ToIjk(tmp2);
				retColor.a = origColor.a;
				
				return retColor;
			}
			ENDCG
		}
	}
	FallBack off
}
