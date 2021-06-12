using UnityEngine;

public class ShopQueue : MonoBehaviour
{
    [SerializeField] GameObject point;
    private float xDist;
    private float incr;
    // Start is called before the first frame update
    void Start()
    {
        xDist = 2.5f;
        incr = xDist;
    }

    public GameObject CreatePosition()
    {
        GameObject pos = Instantiate(point, new Vector3(transform.position.x + xDist, 
                                                        transform.position.y, 
                                                        transform.position.z), 
                                                        Quaternion.identity);
        pos.transform.parent = gameObject.transform;
        xDist += incr;

        return pos;
    }
}
