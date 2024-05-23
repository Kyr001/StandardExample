using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    // [구현사항 1] 정적 필드 정의
    private static QuestManager instance;

    // [구현사항 2] 정적 프로퍼티 정의
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

    // [구현사항 3] 인스턴스 검사 로직
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
