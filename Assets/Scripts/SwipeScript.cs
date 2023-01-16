using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeScript : MonoBehaviour
{
    public GameObject scrollbar;
    private float scrollPos = 0;
    private float[] pos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pos = new float[transform.childCount];
        float distance = 1.0f / (pos.Length - 1.0f);

        for (int i = 0; i < pos.Length; i++)
        {
            pos[i] = distance * i;
        }

        if (Input.GetMouseButton(0))
        {
            scrollPos = scrollbar.GetComponent<Scrollbar>().value;
        }
        else
        {
            for (int i = 0; i < pos.Length; i++)
            {
                if (scrollPos < pos[i] + (distance / 2) && scrollPos > pos[i] - (distance / 2))
                {
                    scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, pos[i], 0.1f);
                }
            }
        }

        //for (int i = 0; i < pos.Length; i++)
        //{
        //    if (scrollPos < pos[i] + (distance / 2) && scrollPos > pos[0] - (distance / 2))
        //    {
        //        transform.GetChild(i).localScale = Vector2.Lerp(transform.GetChild(i).localScale, new Vector2(1f, 1f), 0.1f);
        //        for (int j = 0; j < pos.Length; j++)
        //        {
        //            if (j != i)
        //            {
        //                transform.GetChild(j).localScale = Vector2.Lerp(transform.GetChild(j).localScale, new Vector2(0.8f, 0.8f), 0.1f);
        //            }
        //        }
        //    }
        //}
    }
}
