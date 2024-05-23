using UnityEngine;
using System.Collections.Generic;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;
    private List<GameObject> pool = new List<GameObject>();
    private Dictionary<string, GameObject> pools = new Dictionary<string, GameObject>();
    public int poolSize = 300;
   
    void Start()
    {
        // 미리 poolSize만큼 게임오브젝트를 생성한다.
        for(int i = 0; i < poolSize; i++)
            //new List<GameObject>().Add(prefab);
            pools.Add("Monster", prefab);


    }

    public GameObject Get()
    {
        // 꺼져있는 게임오브젝트를 찾아 active한 상태로 변경하고 return 한다.
        if(!gameObject.activeInHierarchy)
        {
            gameObject.SetActive(true);
        }
        return gameObject;
    }

    public void Release(GameObject obj)
    {
        // 게임오브젝트를 deactive한다.
        obj.SetActive(false);
    }
}