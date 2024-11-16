using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public Material newMaterial; // Новый материал, который нужно применить
    public string Tag;

    void Start()
    {
        ChangeAllObjectsMaterialWithTag(Tag); // Ваш тег объектов, на которых нужно изменить материал
    }

    void ChangeAllObjectsMaterialWithTag(string tag)
    {
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(tag); // Находим все объекты с указанным тегом
        foreach (GameObject obj in objectsWithTag)
        {
            Renderer renderer = obj.GetComponent<Renderer>(); // Получаем компонент Renderer объекта
            if (renderer != null) // Проверяем, что объект имеет компонент Renderer
            {
                renderer.material = newMaterial; // Применяем новый материал к объекту
            }
        }
    }
}