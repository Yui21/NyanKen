#ifndef JP_GULTI_COLORBLIND_INC
#define JP_GULTI_COLORBLIND_INC

inline fixed3 IjkToRgb1(fixed3 ijk_color)
{
	return fixed3(pow(ijk_color.r, 2.2), pow(ijk_color.g, 2.2), pow(ijk_color.b, 2.2));
}
inline fixed3 Rgb1ToRgb2_Type1(fixed3 rgb1)
{
	return rgb1 * 0.992052 + fixed3(0.003974, 0.003974, 0.003974);
}
inline fixed3 Rgb1ToRgb2_Type2(fixed3 rgb1)
{
	return rgb1 * 0.957237 + fixed3(0.0213814, 0.0213814, 0.0213814);
}
inline fixed3 Rgb2ToRgb1_Type1(fixed3 rgb2)
{
	 return (rgb2 - fixed3(0.003974, 0.003974, 0.003974)) / 0.992052;
}
inline fixed3 Rgb2ToRgb1_Type2(fixed3 rgb2)
{
	return (rgb2 - fixed3(0.0213814, 0.0213814, 0.0213814)) / 0.957237;
}

inline fixed3 Rgb2ToIjk(fixed3 rgb2_color)
{
	//not need to inverse
	//fixed3 rgb1 = (rgb2_color - fixed3(0.003974, 0.003974, 0.003974)) / 0.992052;

	const fixed inv_power = 1.0 / 2.2;
	return fixed3(pow(rgb2_color.r, inv_power), pow(rgb2_color.g, inv_power), pow(rgb2_color.b, inv_power));
}

inline fixed3 Rgb2ToLms(fixed3 rgb_color)
{
	const fixed3x3 RGBtoLMS = fixed3x3
	(
	0.845931878,	38.46415026,	0.108924814,
	-7.653893956,	43.87643058,	1.749588988,
	-1.4891935142,	6.2481163464,	1.7825102618
	);
	return mul(RGBtoLMS, rgb_color);
}
inline fixed3 LmsToRgb2(fixed3 lms_color)
{
	const fixed3x3 LMStoRGB = fixed3x3
	(
	0.13918479174911,	-0.14043354169658,	0.12933462739926,
	0.02283455074609,	0.003455060379214,	-0.0047866118742697,
	0.036241114989974,	-0.12943562999231,	0.68583705933084
	);
	return mul(LMStoRGB, lms_color);
}

inline fixed3 Rgb2ToXyz(fixed3 rgb_color)
{
	const fixed3x3 RGBtoXYZ = fixed3x3
	(
		40.9568,	35.5041,	17.9167,
		21.3389,	70.6743,	7.9868,
		1.86297,	11.4620,	91.2367
	);
	return mul(RGBtoXYZ, rgb_color);
}
inline fixed3 XyzToRgb2(fixed3 xyz_color)
{
	const fixed3x3 XYZtoRGB = fixed3x3
	(
		0.032804146754602,		-0.015657092464101,		-0.0050713363160428,
		-0.0099705093905421,	0.0191120146409,		0.00028491590624813,
		0.00058275712903878,	-0.0020813249302764,	0.01102825991404
	);
	return mul(XYZtoRGB, xyz_color);
}

inline fixed3 XyzToLms(fixed3 xyz_color)
{
	const fixed3x3 XYZtoLMS = fixed3x3
	(
		0.15514, 	0.54312,	-0.03286,
		-0.15514, 	0.45684,	0.03286,
		0, 			0,			0.01608
	);
	return mul(XYZtoLMS, xyz_color);
}
inline fixed3 LmsToXyz(fixed3 lms_color)
{
	const fixed3x3 LMStoXYZ = fixed3x3
	(
		2.9448129066068,	-3.5009779919365,	13.172182147147,
		1.0000400016001,	1.0000400016001,	0,
		0,					0,					62.189054726368
	);
	return mul(LMStoXYZ, lms_color);
}

inline fixed3 LmsColorBlindType1(fixed3 lms_normal, fixed intensity)
{
	return fixed3(intensity * (lms_normal.g * 2.02344 - lms_normal.b * 2.52581) + (1 - intensity) * lms_normal.r, lms_normal.g, lms_normal.b);
}
inline fixed3 LmsColorBlindType2(fixed3 lms_normal, fixed intensity)
{
	return fixed3(lms_normal.r, intensity * (lms_normal.r * 0.494207 + lms_normal.b * 1.24827) + (1 - intensity) * lms_normal.g, lms_normal.b);
}

#endif
