Shader "Custom/RimShader"
{
  Properties
	{

		_RimPower("Rim Power", Range(0.5,8.0))=0.64
        _Albedo("Albedo", 2D) ="white"{}
	}

	Subshader
	{
		Tags{"Queue"="Transparent"}
		
		Pass 
		{
			ZWrite On
			ColorMask 0
		}
		
		
		
		CGPROGRAM
		#pragma surface surf Lambert alpha:fade

		struct Input 
		{
            float2 uv_myDiffuse;
			float3 viewDir;
		};

		float _RimPower;
        sampler2D _Albedo;

		void surf(Input IN, inout SurfaceOutput o)
		{
			half rim = 1.0- saturate(dot(normalize(IN.viewDir),o.Normal));
			o.Emission= tex2D(_Albedo, IN.uv_myDiffuse).rgb*pow(rim,_RimPower)*10;
			o.Alpha = pow(rim,_RimPower);
            o.Albedo = tex2D(_Albedo, IN.uv_myDiffuse).rgb;
		}

		ENDCG
	}
}
