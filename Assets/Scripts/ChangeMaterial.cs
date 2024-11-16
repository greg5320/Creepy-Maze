using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material newMaterial; // ����� ��������, ������� ����� ���������
    public string Tag;

    void Start()
    {
        ChangeAllObjectsMaterialWithTag(Tag); // ��� ��� ��������, �� ������� ����� �������� ��������
    }

    void ChangeAllObjectsMaterialWithTag(string tag)
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(tag); // ������� ��� ������� � ��������� �����
        foreach (GameObject obj in objectsWithTag)
        {
            Renderer renderer = obj.GetComponent<Renderer>(); // �������� ��������� Renderer �������
            if (renderer != null) // ���������, ��� ������ ����� ��������� Renderer
            {
                renderer.material = newMaterial; // ��������� ����� �������� � �������
            }
        }
    }
}