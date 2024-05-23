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
        // �̸� poolSize��ŭ ���ӿ�����Ʈ�� �����Ѵ�.
        for(int i = 0; i < poolSize; i++)
            //new List<GameObject>().Add(prefab);
            pools.Add("Monster", prefab);


    }

    public GameObject Get()
    {
        // �����ִ� ���ӿ�����Ʈ�� ã�� active�� ���·� �����ϰ� return �Ѵ�.
        if(!gameObject.activeInHierarchy)
        {
            gameObject.SetActive(true);
        }
        return gameObject;
    }

    public void Release(GameObject obj)
    {
        // ���ӿ�����Ʈ�� deactive�Ѵ�.
        obj.SetActive(false);
    }
}