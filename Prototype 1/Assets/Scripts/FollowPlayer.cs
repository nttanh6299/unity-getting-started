using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    private Vector3 view;

    // Start is called before the first frame update
    void Start()
    {
        view = get3rdPersonView();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + view;
    }

    Vector3 get3rdPersonView()
    {
        return new Vector3(0, 4, -8);
    }
}
