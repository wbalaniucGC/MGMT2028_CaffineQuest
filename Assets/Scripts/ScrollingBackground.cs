using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float scrollSpeedX = 0.5f;
    public float pixelSize = 0.1f;
    private Renderer rend;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rend = GetComponent<Renderer>();   
    }

    // Update is called once per frame
    void Update()
    {
        float offsetX = Mathf.Floor(Time.time * scrollSpeedX / pixelSize) * pixelSize;
        rend.material.SetTextureOffset("_MainTex", new Vector2(offsetX, 0));
    }
}
