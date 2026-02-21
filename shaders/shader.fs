#version 330 core
out vec4 FragColor; // The final color output for this pixel

in vec3 ourColor;   // The input color passed from the vertex shader
in vec2 TexCoord;

uniform sampler2D texture1;
uniform sampler2D texture2;

void main()
{
    // Set the pixel color (RGB + Alpha)
    FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), 0.3f);
}