using NUnit.Framework;
using TMPro;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    enum Type
    {
        Item,
        Bomb,
        FallingObject
    }
    Type type = Type.Item;
    public int totalScore;
    public int itemCount = 20;
    public int bombCount = 20;
    public int FallingObjectCount = 20;
    public FallingObject[] objList;
    public int totalCount = 0;
    public TMP_Text score;
    public TMP_Text status;
    Rigidbody rb;
    int number;


    private void Start()
    {
        spawnObjects(Type.Item);
        spawnObjects(Type.Bomb);
        spawnObjects(Type.FallingObject);

        rb = GetComponent<Rigidbody>(); // 캐싱, 래퍼런싱
        rb.isKinematic = true;

        number = 10;

/*        for (int i = 0; i < count; i++)
        {
            Vector3 newPos = new Vector3(Random.Range(0, 10), Random.Range(0, 100), Random.Range(0, 10));

            GameObject sphere = Instantiate(GameObject.CreatePrimitive(PrimitiveType.Sphere));

            sphere.transform.position = newPos;

            if (i % 5 == 0)
            {
                sphere.AddComponent<Rigidbody>().useGravity = false; // 컴포넌트 추가 + 중력설정 off
                sphere.GetComponent<Collider>().isTrigger = true; // 컴포넌트 가져오기 + trigger On
            }
            else
            {
                sphere.AddComponent<Rigidbody>().useGravity = true; // 컴포넌트 추가 + 중력설정 off
                sphere.GetComponent<Collider>().isTrigger = false; // 컴포넌트 가져오기 + trigger On

                if (i % 3 == 0)
                {
                    sphere.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(0, 5),
                        Random.Range(0, 5), Random.Range(0, 5)), ForceMode.Impulse);
                }
            }

            sphere.GetComponent<Collider>().isTrigger = false; // 컴포넌트 가져오기 + trigger On

            sphere.tag = "Metal";
        }*/
    }

    private void spawnObjects(Type type)
    {
        switch (type)
        {
            case Type.Item:
                for(int i = 0; i < itemCount; i++)
                {
                    Vector3 itemPos = new Vector3(Random.Range(0, 10), Random.Range(0, 100), Random.Range(0, 10));
                    GameObject item = Instantiate(GameObject.CreatePrimitive(PrimitiveType.Sphere));
                    item.transform.position = itemPos;
                    item.GetComponent<Collider>().isTrigger = true;
                    item.GetComponent<MeshRenderer>().material.color = Color.red;
                }

                break;
            case Type.Bomb:
                for (int i = 0; i < bombCount; i++)
                {
                    Vector3 bombPos = new Vector3(Random.Range(0, 10), Random.Range(0, 100), Random.Range(0, 10));
                    GameObject bomb = Instantiate(GameObject.CreatePrimitive(PrimitiveType.Cube));
                    bomb.transform.position = bombPos;
                    bomb.AddComponent<Rigidbody>().useGravity = false;
                    bomb.GetComponent<MeshRenderer>().material.color = Color.green;
                }

                break;
            case Type.FallingObject:

                objList = new FallingObject[FallingObjectCount];
                for (int i = 0; i < FallingObjectCount; i++)
                {
                    Vector3 objPos = new Vector3(Random.Range(0, 10), Random.Range(100, 200), Random.Range(0, 10));
                    GameObject obj = Instantiate(GameObject.CreatePrimitive(PrimitiveType.Capsule));
                    obj.transform.position = objPos;
                    obj.AddComponent<Rigidbody>().useGravity = true;
                    FallingObject fo = obj.AddComponent<FallingObject>();
                    fo.randomSpawn = this;
                    objList[i] = fo;
                    obj.GetComponent<MeshRenderer>().material.color = Color.blue;
                }

                Camera.main.transform.SetParent(objList[0].transform);
                Camera.main.transform.localPosition = Vector3.zero;

                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        score.text = totalScore.ToString();
    }
}
