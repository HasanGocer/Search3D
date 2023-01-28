Shader "Custom/CelShader"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Glossiness ("Smoothness", Range(0,1)) = 0.5
        _Metallic ("Metallic", Range(0,1)) = 0.0
        _EdgeColor ("Edge Color", Color) = (0,0,0,1)
        _Threshold ("Threshold", Range(0,1)) = 0.5
        _LightDirection ("Light Direction", Vector) = (0,0,1)
    }

    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 200

        CGPROGRAM
        // Physically based Standard lighting model, and enable shadows on all light types
        #pragma surface surf Standard fullforwardshadows

        // Use shader model 3.0 target, to get nicer looking lighting
        #pragma target 3.0

        sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        half _Glossiness;
        half _Metallic;
        fixed4 _Color;
        fixed4 _EdgeColor;
        half _Threshold;
        float3 _LightDirection;

        void surf (Input IN, inout SurfaceOutputStandard o)
        {
            // Sample the texture at the UV coordinates
            fixed4 texel = tex2D (_MainTex, IN.uv_MainTex);

            // Calculate lighting effects
            o.Metallic = _Metallic;
            o.Smoothness = _Glossiness;
            o.Alpha = texel.a * _Color.a;

            // Calculate surface color based on lighting and texture
            fixed3 lighting = _Color.rgb * texel.rgb;
            // Calculate edge color based on surface normal
            fixed3 normal = UnpackNormal (texel);
            fixed edge = 1 - saturate (dot (normal, _LightDirection));
            fixed3 edgeColor = lerp (_Color.rgb, _EdgeColor.rgb, edge);
            // Blend between surface color and edge color based on lighting intensity
o.Albedo = lerp (edgeColor, lighting, step (_Threshold, lighting));
}
ENDCG
}
FallBack "Universal Render Pipeline/Lit"
}