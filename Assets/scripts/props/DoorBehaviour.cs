using UnityEngine;

public class DoorBehaviour : MonoBehaviour {
    public GameObject player;
    private Vector3 position;
    private Renderer surface;
    private Vector3 plPosition;
    private float[] initialCoordenates;

	// Use this for initialization
	void Start () {       
        position = transform.position;
        surface = GetComponent<Renderer>();
        initialCoordenates = new float[] { position.x, position.y, position.z};
	}
	
	// Update is called once per frame
	void Update () {
        plPosition = player.transform.position;
        float distance = Vector3.Distance(plPosition, position);            
        if (distance < 2.5)
        {
            RenderUtils.colorizeGreen(surface);
            transform.Translate(initialCoordenates[0], 1, initialCoordenates[2]);
        }
        else
        {
            RenderUtils.colorizeLightGreen(surface);           
        }
        print("Distance: " + distance);
	}
}
