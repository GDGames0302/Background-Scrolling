using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    [SerializeField]
    private Vector2 scrollSpeed;

    private Material materialToScroll;


    private void Start()
    {
        materialToScroll = GetComponent<Renderer>().material;
    }

    private void Update()
    {
        materialToScroll.mainTextureOffset += scrollSpeed * Time.deltaTime;
    }
}