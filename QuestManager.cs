using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    // [�������� 1] ���� �ʵ� ����
    private static QuestManager instance;

    // [�������� 2] ���� ������Ƽ ����
    public static QuestManager Instance
    {
        get
        {
            if (instance == null)
            {
                FindObjectOfType<QuestManager>();
            }
            else
            {
                GameObject gameObject = new GameObject("QuestManager");
                QuestManager questManger = gameObject.AddComponent<QuestManager>();
            }

            return instance;
        }
    }

    // [�������� 3] �ν��Ͻ� �˻� ����
    private void Awake()
    {
        if(instance == null && instance != this)
        {
            Destroy(gameObject);
        }
        else
            instance = this;
    }
}
