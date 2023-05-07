Shader "Custom\ПодводноеДвижение"
{
    Properties
    {
        [PerRendererData]
        _MainTex ("Main Texture", 2D) = "white" {}
        _Color ("Color" , Color) = (1,1,1,1)
    }

    SubShader
    {
        Tags
        {
            "RenderType" = "Transparent"
            "Queue" = "Transparent"
        }

        Cull Off
        Blend SrcAlpha OneMinusSrcAlpha
	Blend Off
        
        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
        
            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
                float4 color : COLOR;
            };

            struct v2f
            {
                float4 vertex : SV_POSITION;
                float2 uv : TEXCOORD0;
                float4 color : COLOR;
		        float4 grabPos : TEXCOORD1;
            };

            fixed4 _Color;
            sampler2D _MainTex;
            sampler2D _GrabTexture;            

            v2f vert (appdata v)
            {
                v2f o;
                o.uv = v.uv;
                o.color = v.color;
                o.vertex = UnityObjectToClipPos(v.vertex);
		        o.grabPos = ComputeGrabScreenPos (o.vertex);
		        o.grabPos /= o.grabPos.w;
                return o;
            }
            
            fixed4 frag (v2f i) : SV_Target
            {
		        fixed4 grabColor = tex2D(_GrabTexture, i.grabPos.xy);                           
                fixed4 texColor = tex2D(_MainTex, i.uv)*i.color;                                
                return texColor;
            }
            ENDCG
        }
    }
}